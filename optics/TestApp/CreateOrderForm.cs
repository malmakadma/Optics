using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class CreateOrderForm : Form
    {
        private int _customerId = 0;
        private NpgsqlConnection _conn;
        NpgsqlCommand command;
        public CreateOrderForm()
        {
            InitializeComponent();

        }

        public CreateOrderForm(int customerId, string customerName, string customerAddress, string phone, DataTable products, NpgsqlConnection conn)
        {
            InitializeComponent();

            _customerId = customerId;
            _conn = conn;
            dgProducts.DataSource = products;
            tbFirstLastName.Text = customerName;
            tbAddress.Text = customerAddress;
            tbPhone.Text = phone;

            //dgOrderItems.Columns.Add(new DataGridViewColumn
            //{
            //    Name = "Product Name"
            //});
            //dgOrderItems.Columns.Add(new DataGridViewColumn
            //{
            //    Name = "Qty"
            //});
            //dgOrderItems.Columns.Add(new DataGridViewColumn
            //{
            //    Name = "Price"
            //});

            System.Windows.Forms.DataGridViewTextBoxColumn Id;
            System.Windows.Forms.DataGridViewTextBoxColumn Name;
            System.Windows.Forms.DataGridViewTextBoxColumn Qty;
            System.Windows.Forms.DataGridViewTextBoxColumn Price;

            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();

            Id.Width = 20;

            dgOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                Id,
                Name,
                Price,
                Qty});

            Id.HeaderText = "Id";
            Id.Name = "Id";

            Name.HeaderText = "Name";
            Name.Name = "Name";

            Price.HeaderText = "Price";
            Price.Name = "Price";

            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";

            LoadEmployees();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgOrderItems.CurrentRow == null || dgOrderItems.CurrentRow.Index == 0)
                return;
            dgOrderItems.Rows.RemoveAt(dgOrderItems.CurrentRow.Index);
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            dgOrderItems.Rows.Add(dgProducts.CurrentRow.Cells[0].Value, dgProducts.CurrentRow.Cells[1].Value, dgProducts.CurrentRow.Cells[3].Value, nQty.Value.ToString()) ;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            SaveOrder();
            
        }

        private void LoadEmployees()
        {
            string sql = "SELECT id, lastname from public.employees";

            var employeesDT = ExecuteReaderCommand(sql, _conn);

            var _employees = (from DataRow dr in employeesDT.Rows
                            select new
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Name = dr["lastname"].ToString()

                            }).ToList();

            cbEmployees.DataSource = _employees;
            cbEmployees.DisplayMember = "Name";
            cbEmployees.ValueMember = "Id";

        }

        private void SaveOrder()
        {
            string sql = "INSERT INTO public.orders(customerid, createdDate, employeeid) " +
                "VALUES (@customerid, @createdDate, @employeeid)";

            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("customerid", _customerId);
            command.Parameters.AddWithValue("createdDate", DateTime.Now);
            command.Parameters.AddWithValue("employeeid", cbEmployees.SelectedValue);

            int orderId = 0;

            _conn.Open();

            var orderWasCreated = command.ExecuteNonQuery()==1?true:false;
            command.Dispose();
            //_conn.Close();

            if (orderWasCreated)
            {
                sql = "Select id FROM orders " +
                "ORDER BY id DESC";

                command = new NpgsqlCommand(sql, _conn);
                orderId = int.Parse(command.ExecuteScalar().ToString());

                sql = "INSERT INTO public.orderItems(orderid, productid, price, quantity) " +
                        "VALUES (@orderid, @productid, @price, @qty)";

                command.CommandText = sql;

                for (int i = 0; i < dgOrderItems.RowCount; i++)
                {
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("orderid", orderId);
                    command.Parameters.AddWithValue("productid", dgOrderItems.Rows[i].Cells[0].Value);
                    command.Parameters.AddWithValue("price", dgOrderItems.Rows[i].Cells[2].Value);
                    command.Parameters.AddWithValue("qty", int.Parse(dgOrderItems.Rows[i].Cells[3].Value.ToString()));

                    command.ExecuteNonQuery();
                }

                command.Dispose();

                MessageBox.Show("Order was created. Form will be closed", "Order was created");
                _conn.Close();
                this.Close();
                
            }

            _conn.Close();

            //    for (int j = 0; j < i+1; j++)
            //    {
            //        var result = command.ExecuteNonQuery();
            //        if (result != 1)
            //        {
            //            MessageBox.Show("Item was not inserted");
            //        }
            //    }
        }

        private DataTable ExecuteReaderCommand(string sql, NpgsqlConnection conn)
        {
            DataTable dt = null;

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

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
    }
}
