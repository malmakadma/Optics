using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models;

namespace TestApp
{
    public partial class MainForm : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Database=optics;Password=OpticsPass22");

        OrderReceipt receipt = new OrderReceipt();

        public MainForm()
        {
            InitializeComponent();
            LoadCustomers();
            dgCustomers.ClearSelection();


            LoadProducts();


            //See if any printers are installed  
            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show("Printer not found!");
                return;
            }

            //Get all available printers and add them to the combo box  
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                printersList.Items.Add(printer.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application will be closed", "Application closing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void AddCustomer(Customer customer, NpgsqlConnection conn)
        {
            customer.CreatedDate = DateTime.Now;

            conn.Open();

            // Define a query returning a single row result set
            //NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM information_schema.tables", conn);
            NpgsqlCommand command;

            string sql = "INSERT INTO public.customers(firstName, LastName, Phone, Email, DoB, Address, Country, CreatedDate) " +
                "VALUES (@firstName, @lastName, @phone, @email, @dob, @address, @country, @createdDate)";

            command = new NpgsqlCommand(sql, conn);
            command.Parameters.AddWithValue("firstName", customer.FirstName);
            command.Parameters.AddWithValue("lastName", customer.LastName);
            command.Parameters.AddWithValue("phone", customer.Phone);
            command.Parameters.AddWithValue("email", customer.Email);
            command.Parameters.AddWithValue("dob", customer.DoB);
            command.Parameters.AddWithValue("address", customer.Address);
            command.Parameters.AddWithValue("country", customer.Country);
            command.Parameters.AddWithValue("createdDate", customer.CreatedDate);

            var result = command.ExecuteNonQuery();
            if (result != 1)
            {
                MessageBox.Show("Item was not inserted");
            }

            command.Dispose();

            conn.Close();
        }

        private void btnFillData_Click(object sender, EventArgs e)
        {
            //conn.Open();

            //var order = new Order() {
            //    CreatedDate = DateTime.Now.AddDays(-10)
            //};

            //Order tempOrder = null;

            //for (int i = 2; i < 6; i++)
            //{
            //    tempOrder = order;
            //    tempOrder.CustomerId = i;
            //    tempOrder.CreatedDate = tempOrder.CreatedDate.AddDays(i+1);





            //    string sql = "INSERT INTO public.orders(customerid, createdDate) " +
            //    "VALUES (@customerid, @createdDate)";

            //    command = new NpgsqlCommand(sql, conn);
            //    command.Parameters.AddWithValue("customerid", tempOrder.CustomerId);
            //    command.Parameters.AddWithValue("createdDate", tempOrder.CreatedDate);

            //    for (int j = 0; j < i+1; j++)
            //    {
            //        var result = command.ExecuteNonQuery();
            //        if (result != 1)
            //        {
            //            MessageBox.Show("Item was not inserted");
            //        }
            //    }
                

            //    command.Dispose();

            //}


            //conn.Close();


        }

        private void LoadCustomerOrders()
        {
            int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());


            dgOrders.DataSource = null;
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("SELECT o.*, em.lastName as EmployeeLastName FROM public.orders as o " +
                "join employees as em on o.employeeid = em.id" +
                " where o.customerid = @customerid ", conn);
            command.Parameters.AddWithValue("customerid", customerId);

            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgOrders.DataSource = dt;
            }
            reader.Close();

            command.Dispose();
            conn.Close();
        }

        private void LoadProducts(string searchStr = "")
        {
            dgProducts.DataSource = null;
            dgProducts.DataSource = GetProducts(searchStr);
        }

        //СОРТИРОВКА 2
        private void LoadProducts2(string searchStr = "")
        {
            dgProducts.DataSource = null;
            dgProducts.DataSource = GetProducts2(searchStr);
        }

        private DataTable GetProducts2(string filter = "")
        {
            string sql = "SELECT * FROM public.products";
            if (!string.IsNullOrEmpty(filter))
            {
                sql = sql + " where " + filter;
            }

            switch (cbnameDirection.SelectedIndex)
            {
                case 0:
                    sql = sql + " order by name Asc";
                    break;
                case 1:
                    sql = sql + " order by name Desc";
                    break;
                default:
                    sql = sql + " order by id";
                    break;
            }
            
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);

            return ExecuteReaderCommand(command, conn);

        }
        private DataTable GetProducts(string filter = "")
        {
            string sql = "SELECT * FROM public.products";
            if (!string.IsNullOrEmpty(filter))
            {
                sql = sql + " where " + filter;
            }

            switch (cbOrderDirection.SelectedIndex)
            {
                case 0: sql = sql + " order by price Desc";
                    break;
                case 1: sql = sql + " order by price Asc";
                    break;
                default: sql = sql + " order by id";
                    break;
            }

            
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);

            return ExecuteReaderCommand(command, conn);

        }

        private DataTable ExecuteReaderCommand(NpgsqlCommand cmd, NpgsqlConnection conn)
        {
            DataTable dt = null;

            try
            {
                conn.Open();

                NpgsqlDataReader reader = cmd.ExecuteReader();
                

                if (reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(reader);
                }
                reader.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return dt;
        }

        private void LoadCustomers(string searchStr = "")
        {
            dgOrders.DataSource = null;
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.customers c where" +
                " c.lastname like '%" + searchStr + "%'" +
                " order by id", conn);

            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgCustomers.DataSource = dt;
            }
            else
            {
                dgCustomers.DataSource = null;
            }
            reader.Close();

            command.Dispose();
            conn.Close();
        }

        private void GetCustomerOrders(int customerId)
        {
            dgOrders.DataSource = null;
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.orders where customerid = @customerid order by id", conn);
            command.Parameters.AddWithValue("customerid", customerId);

            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgOrders.DataSource = dt;
            }
            reader.Close();

            command.Dispose();
            conn.Close();
        }

        private void LoadOrderItems()
        {
            dgOrderItems.DataSource = null;

            if (dgOrders.CurrentCell == null)
                return;

            int orderId = int.Parse(dgOrders.Rows[dgOrders.CurrentCell.RowIndex].Cells[0].Value.ToString());
            if (orderId < 1)
            {
                return;
            }

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("SELECT oi.id, oi.price, oi.quantity, p.Name, oi.recipeid FROM public.orderitems as oi" +
                " INNER JOIN public.products as p on oi.productid = p.id where oi.orderid = @orderId", conn);
            command.Parameters.AddWithValue("orderId", orderId);

            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgOrderItems.DataSource = dt;
            }
            reader.Close();

            command.Dispose();
            conn.Close();
        }

        private bool DeleteOrderItem(int orderItemId)
        {
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("DELETE from orderitems where id = @orderItemId", conn);
            command.Parameters.AddWithValue("orderItemId", orderItemId);

            var result = command.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
            
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            };            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCustomers.RowCount > 0)
            {
                int customerId = int.Parse(dgCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
                LoadCustomerOrders();

                LoadOrderItems();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(dgCustomers.Rows[dgCustomers.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditCustomerForm new_Form = new EditCustomerForm(customerId, conn);
            new_Form.ShowDialog();
        }

        private void dgOrders_Click(object sender, EventArgs e)
        {
            LoadOrderItems();
        }

        private void dgCustomers_SelectionChanged(object sender, EventArgs e)
        {
            int customerId = int.Parse(dgCustomers.Rows[dgCustomers.CurrentCell.RowIndex].Cells[0].Value.ToString());
            GetCustomerOrders(customerId);

            LoadOrderItems();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgOrderItems.Rows.Count <= 1)
            {
                MessageBox.Show("Item can't be deleted!");
                return;
            }
                

            DialogResult dialogResult = MessageBox.Show("Item will be deleted. Are you sure?", "Delete item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int orderItemId = int.Parse(dgOrderItems.Rows[dgOrderItems.CurrentCell.RowIndex].Cells[0].Value.ToString());

                DeleteOrderItem(orderItemId);

                LoadOrderItems();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnEditOrderItem_Click(object sender, EventArgs e)
        {
            if (dgOrderItems.CurrentCell == null)
                return;

            int orderItemId = int.Parse(dgOrderItems.Rows[dgOrderItems.CurrentCell.RowIndex].Cells[0].Value.ToString());
            var products = GetProducts();
            int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());

            EditOrderItem new_Form = new EditOrderItem(customerId, null, orderItemId, products, conn);
            new_Form.FormClosed += new FormClosedEventHandler(OrderItem_FormClosed);


            new_Form.ShowDialog();
        }

        private void OrderItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadOrderItems();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProducts.Rows[dgProducts.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditProduct new_Form = new EditProduct(id, conn);

            new_Form.FormClosed += new FormClosedEventHandler(child_FormClosed);
            new_Form.ShowDialog();

        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadProducts();
        }

        void customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomers();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditCustomerForm new_Form = new EditCustomerForm(conn);
            //new_Form.FormClosed += new FormClosedEventHandler(customer_FormClosed);

            new_Form.ShowDialog();
        }

        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCustomerOrders();
            LoadOrderItems();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var customerRaw = dgCustomers.CurrentRow;
            int customerId = int.Parse(customerRaw.Cells[0].Value.ToString());
            string name = customerRaw.Cells[1].Value +" "+ customerRaw.Cells[2].Value;
            string address = customerRaw.Cells[7].Value +" "+ customerRaw.Cells[8].Value;
            string phone = customerRaw.Cells[3].Value.ToString();

            var products = GetProducts();

            CreateOrderForm new_Form = new CreateOrderForm(customerId, name, address, phone, products, conn);
            new_Form.FormClosed += new FormClosedEventHandler(Order_FormClosed);

            new_Form.ShowDialog();
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomerOrders();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            EditProduct new_Form = new EditProduct(null, conn);

            new_Form.FormClosed += new FormClosedEventHandler(child_FormClosed);
            new_Form.ShowDialog();
        }

        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            if (dgOrderItems.CurrentCell == null)
                return;

            int orderId = int.Parse(dgOrders.CurrentRow.Cells[0].Value.ToString());
            int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
            var products = GetProducts();
            EditOrderItem new_Form = new EditOrderItem(customerId, orderId, null, products, conn);
            new_Form.FormClosed += new FormClosedEventHandler(OrderItem_FormClosed);


            new_Form.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            dgCustomers.ClearSelection();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLForm new_Form = new SQLForm(conn);
            new_Form.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm new_Form = new ReportsForm(conn);
            new_Form.ShowDialog();
        }

        private void bDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgProducts.CurrentCell == null)
                return;

            int productId = int.Parse(dgProducts.CurrentRow.Cells[0].Value.ToString());
            if (productId < 1)
            {
                return;
            }

            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("Delete from products where id = @id", conn);
            command.Parameters.AddWithValue("id", productId);

            try
            {
                var affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Looks like there are orders with this product. " +
                     "Product can't be deleted");
            }
            

            command.Dispose();
            conn.Close();
        }

        private void bPrintOrder_Click(object sender, EventArgs e)
        {
            if (dgOrders.CurrentRow == null || printersList.SelectedIndex <0)
            {
                MessageBox.Show("Select all params", "Printer and/or order is not selected");
                return;
            }

            receipt.CustomerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
            receipt.CustomerFirstName = dgCustomers.CurrentRow.Cells[1].Value.ToString();
            receipt.CustomerLastName = dgCustomers.CurrentRow.Cells[2].Value.ToString();

            receipt.CreatedDate = DateTime.Parse(dgOrders.CurrentRow.Cells[2].Value.ToString());
            receipt.Id = int.Parse(dgOrders.CurrentRow.Cells[0].Value.ToString());

            //
            receipt.Employee = dgOrders.CurrentRow.Cells[4].Value.ToString();
            receipt.items = new List<OrderItem>();

            foreach (DataGridViewRow row in dgOrderItems.Rows)
            {
                receipt.items.Add(
                        new OrderItem()
                        {
                            Id = int.Parse(row.Cells[0].Value.ToString()),
                            Qty = int.Parse(row.Cells[2].Value.ToString()),
                            Price = decimal.Parse(row.Cells[1].Value.ToString()),
                            ProductName = row.Cells[3].Value.ToString(),

                        }
                    );
            }
            

            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();

            //Set PrinterName as the selected printer in the printers list  
            pd.PrinterSettings.PrinterName =
            printersList.SelectedItem.ToString();

            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            //Print the document  
            pd.Print();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //Get the Graphics object  
            Graphics g = ev.Graphics;
 
            Font font = new Font("Arial", 14);

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            
            g.DrawString("Чек для замовлення #" + receipt.Id,
            font, brush,
            new Rectangle(320, 100, 400, 20));
            g.DrawString("День замовлення #" + receipt.CreatedDate.ToShortDateString(),
            font, brush,
            new Rectangle(60, 140, 400, 20));

            var counter = 1;
            var y = 180;
            font = new Font("Arial", 12);
            foreach (var item in receipt.items)
            {
                g.DrawString("товар " + counter.ToString()+ ": " + item.ProductName,
                font, brush,
                new Rectangle(60, y, 400, 40));

                g.DrawString("кількість: " + item.Qty.ToString() + "   -> Ціна: " + item.Price,
                font, brush,
                new Rectangle(120, y+20, 400, 40));

                y = y + 40;
                counter += 1;
            }

            font = new Font("Arial", 14);

            g.DrawString("Загальна сума:" + receipt.items.Sum(e=> e.Price* e.Qty).ToString(),
            font, brush,
            new Rectangle(60, y+40, 200, 40));
            
            //DateTime.Now
            g.DrawString("Чек створено " + DateTime.Now,
            font, brush,
            new Rectangle(60, y + 80, 2000, 40));
            //receipt.Employee
            g.DrawString(receipt.Employee + " оформив/ла замовлення ",
            font, brush,
            new Rectangle(60, y + 120, 2000, 40));
        }

        private void PrintOrderReceipt(int orderId)
        { 

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            LoadCustomers(textBox1.Text);
        }

        private void tbProductSearch_KeyUp(object sender, KeyEventArgs e)
        {

            var filterString = " name like '%" + tbProductSearch.Text + "%'";
            LoadProducts(filterString);

        }

        private void bFilterProduct_Click(object sender, EventArgs e)
        {
            StringBuilder sqlFilter = new StringBuilder();
            switch (cbFilterType.SelectedIndex) {
                case 0:
                    sqlFilter.Append(" price > ");
                    break;
                case 1:
                    sqlFilter.Append(" price < ");
                    break;
                case 2:
                    sqlFilter.Append(" price = ");
                    break;
                    
            }

            if (sqlFilter.Length != 0)
            {
                sqlFilter.Append(nudFilterPrice.Value + " ");
                
            }
            // Add 2 filter
            StringBuilder sqlFilter2 = new StringBuilder();


            switch (cbFilterRecipeIsReq.SelectedIndex)
            {
                case 0:
                    sqlFilter2.Append(" True ");
                    break;
                case 1:
                    sqlFilter2.Append(" False ");
                    break;
               
            }

            if (sqlFilter.Length != 0 && cbFilterRecipeIsReq.SelectedIndex >= 0)
            {
                sqlFilter.Append("and recipeisreq = " + sqlFilter2.ToString());
            }
            if (sqlFilter.Length == 0 && cbFilterRecipeIsReq.SelectedIndex >= 0)
            {
                sqlFilter.Append("recipeisreq = " + sqlFilter2.ToString());
            }
            else
            {
                //
            }

            LoadProducts(sqlFilter.ToString());
                
        }

        private void cbOrderDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void bRecipts_Click(object sender, EventArgs e)
        {
            var customerRaw = dgCustomers.CurrentRow;
            int customerId = int.Parse(customerRaw.Cells[0].Value.ToString());

            var new_Form = new RecipeForm(customerId, conn);
            new_Form.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var new_Form = new EmployeeForm(conn);
            new_Form.ShowDialog();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCustomerOrders();
            LoadOrderItems();
        }

        private void cbnameDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
