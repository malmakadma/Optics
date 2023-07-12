using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using TestApp.Models;

namespace TestApp
{
    public partial class ReportsForm : Form
    {
        private int _productId;
        private NpgsqlConnection _conn;

        ZvitMonthly zvit = new ZvitMonthly();
        public ReportsForm()
        {
            InitializeComponent();
        }

        public ReportsForm(NpgsqlConnection conn)
        {
            _conn = conn;
            InitializeComponent();
        }

        private void bRequest1_Click(object sender, EventArgs e)
        {

            lReportName.Text = "Most profitable clients";

            string sql = "Select c.*, SUM(oi.Quantity*oi.Price) as Total from Customers as c " +
                "join Orders as o on c.Id = o.CustomerId " +
                "join OrderItems as oi on o.Id = oi.OrderId " +
                "group By c.Id " +
                "order by SUM(oi.Quantity*oi.Price) " +
                "DESC";

            NpgsqlCommand command;
            command = new NpgsqlCommand(sql, _conn);


            ExecuteAndFill(command);
        }

        private void bRequest2_Click(object sender, EventArgs e)
        {
            lReportName.Text = "Number of customers who placed an order on the selected date";

            NpgsqlCommand command;

            string sql = "Select Count(Id) from Orders as o where o.CreatedDate = @date";

            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("date", dtpR2.Value.Date);


            ExecuteAndFill(command);

        }

        private void bRequest3_Click(object sender, EventArgs e)
        {
            lReportName.Text = "Information about most profitable date";

            NpgsqlCommand command;

            string sql = "Select o.createddate, CONCAT(c.FirstName, c.LastName) as Customer, " +
                "p.Name as Product, oi.Quantity as Qty, oi.Price " +
                "from Products as p " +
                "join OrderItems as oi on p.Id = oi.ProductId " +
                "join Orders as o on oi.OrderId = o.Id " +
                "join Customers as c on o.CustomerId = c.Id " +
                "where o.CreatedDate = " +
                "(" +
                "Select o.CreatedDate from Orders as o " +
                "join OrderItems as oi on o.Id = oi.OrderId " +
                "group by o.CreatedDate " +
                "order by SUM(oi.Quantity* oi.Price) DESC " +
                "limit 1 " +
                ") " +
                "order by c.id";

            command = new NpgsqlCommand(sql, _conn);

            ExecuteAndFill(command);
        }

        private void bRequest4_Click(object sender, EventArgs e)
        {
            //
     
            lReportName.Text = "The most expensive product ";

            NpgsqlCommand command;

            string sql = "Select * from Products as p where p.price in (select Max(price) from products) " +
                "order by p.price DESC";

            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("min", nPrice.Value);

            ExecuteAndFill(command);

        }

        private void ExecuteAndFill(NpgsqlCommand comm)
        {
            NpgsqlCommand command = comm;
            gvReport.DataSource = null;
            try
            {

                _conn.Open();
                
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    gvReport.DataSource = dt;
                }
                reader.Close();

                command.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please check your SQL request. Error message: " + ex.Message, "Something went wrong");
            }
            finally
            {
                _conn.Close();
            }
        }

        private DataTable Execute(NpgsqlCommand comm)
        {
            NpgsqlCommand command = comm;

            DataTable dt = new DataTable();

            try
            {

                _conn.Open();

                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

                command.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please check your SQL request. Error message: " + ex.Message, "Something went wrong");
            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bReport5_Click(object sender, EventArgs e)
        {
            lReportName.Text = "Cross-table - ordered products per month";
            NpgsqlCommand command;

            DateTime now = DateTime.Now;

            gvReport.DataSource = null;

            for (int i = 1; i < 13; i++)
            {
                
                var startDate = new DateTime(now.Year, i, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);



                string sql = "select temp.id, temp.name, SUM(temp.quantity) from " +
                                "( SELECT p.id, p.name, oi.quantity " +
                                "FROM public.orderitems as oi " +
                                "join orders as o on oi.orderid = o.id " +
                                "join products as p on oi.productid = p.id " +
                                "where o.createddate >= @startdate and o.createddate <= @enddate " +
                                "order by p.id " +
                                ") as temp " +
                                "group by temp.id, temp.name " +
                                "order by temp.id";

                command = new NpgsqlCommand(sql, _conn);
                command.Parameters.AddWithValue("startdate", startDate);
                command.Parameters.AddWithValue("enddate", endDate);

                var dt = Execute(command);

                // Get the en-US culture.
                CultureInfo ci = new CultureInfo("en-US");
                // Get the DateTimeFormatInfo for the en-US culture.
                DateTimeFormatInfo dtfi = ci.DateTimeFormat;
                

                if (gvReport.Columns.Count == 0)
                {
                    string sqlProducts = "select name from products order by id";

                    var commandProduct = new NpgsqlCommand(sqlProducts, _conn);

                    var dtProduct = Execute(commandProduct);
                    foreach (DataRow row in dtProduct.Rows)
                    {
                        AddColumn(row[0].ToString(), row[0].ToString());
                    }
                }

                DataGridViewRow gr = new DataGridViewRow();

                foreach (DataRow row in dt.Rows)
                {
                    var t = row[2].ToString();
                    gr.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = row[2].ToString() == "" ? "0" : row[2].ToString()
                    });
                }

                

                gr.HeaderCell.Value = dtfi.GetMonthName(startDate.Month);
                gvReport.Rows.Add(gr);
            }
            gvReport.AutoResizeRowHeadersWidth(
                    0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void AddColumn(string name, string headerText)
        {   
            gvReport.Columns.Add(new DataGridViewTextBoxColumn() { Name = name, HeaderText = headerText, Width = 100 });
        }

        private void bReport6Print_Click(object sender, EventArgs e)
        {
            lReportName.Text = "Customers Monthly statistic: for" + dtpR6.Value.Month.ToString();

            NpgsqlCommand command;

            string sql = "Select c.FirstName, c.LastName,  SUM(oi.Quantity) as Qty, " +
                "SUM(oi.Price * oi.Quantity) as TotalSpent " +
                "from Customers as c " +
                "join Orders as o on c.Id = o.CustomerId " +
                "join OrderItems as oi on o.Id = oi.OrderId " +
                "group by c.id, DATE_TRUNC('month', o.CreatedDate) " +
                "having DATE_TRUNC('month',o.CreatedDate) >= @sdate and DATE_TRUNC('month',o.CreatedDate) <= @edate";


            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("sdate", new DateTime(dtpR6.Value.Year, dtpR6.Value.Month, 1));
            command.Parameters.AddWithValue("edate", new DateTime(dtpR6.Value.Year, dtpR6.Value.Month, DateTime.DaysInMonth(dtpR6.Value.Year, dtpR6.Value.Month)));


            ExecuteAndFill(command);
        }

        // Print Zvit 
        
        //start
        private void bPrint_Click(object sender, EventArgs e)
        {
            if (gvReport.CurrentRow == null)
            {
                MessageBox.Show("Nothing to print");
                return;
            }

            zvit.items = new List<Monthlydata>();

            foreach (DataGridViewRow row in gvReport.Rows)
            {
                zvit.items.Add(
                        new Monthlydata()
                        {
                            firstname = row.Cells[0].Value.ToString(),
                            lastname = row.Cells[1].Value.ToString(),
                            qty = int.Parse(row.Cells[2].Value.ToString()),
                            totalspent = decimal.Parse(row.Cells[3].Value.ToString()),
                        }
                    );
            }

            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();

            //Set PrinterName as the selected printer in the printers list  
            pd.PrinterSettings.PrinterName = "Adobe PDF";

            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            //Print the document
            pd.Print();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Bitmap bm = new Bitmap(gvReport.Width, gvReport.Height);
            // gvReport.DrawToBitmap(bm, new Rectangle(0, 0, gvReport.Width, gvReport.Height));
            // e.Graphics.DrawImage(bm, 0, 0);

            //Get the Graphics object  
            Graphics g = e.Graphics;

            Font font = new Font("Arial", 14);

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            g.DrawString("Звіт",
            font, brush,
            new Rectangle(380, 100, 400, 20));

            g.DrawString("про продаж товарів за " + dtpR6.Value.Month.ToString() + " місяць",
            font, brush,
            new Rectangle(260, 140, 400, 20));


            var counter = 1;
            var y = 200;
            font = new Font("Arial", 12);
            foreach (var item in zvit.items)
            {
                g.DrawString("клієнт " + counter.ToString() + ": " + item.firstname + " "+ item.lastname, 
                font, brush,
                new Rectangle(120, y, 4000, 40));



                g.DrawString("Кількість товарів: " + item.qty,
                font, brush,
                new Rectangle(200, y + 40, 400, 40));

                g.DrawString("Витрати: " + item.totalspent,
                font, brush,
                new Rectangle(200, y + 60, 400, 40));

                y = y + 100;
                counter += 1;
            }
            font = new Font("Arial", 14);
            //DateTime.Now
            g.DrawString("Звіт сформовано " + DateTime.Now,
            font, brush,
            new Rectangle(60, y + 40, 2000, 40));
        }

        //
        
    }
}
