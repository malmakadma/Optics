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
    public partial class EditOrderItem : Form
    {
        private int? _orderItemId;
        private int _customerId;
        private int? _orderId;
        private NpgsqlConnection _conn;

        private List<Product> _productList;

        private EditOrderItem()
        {
            InitializeComponent();

        }

        public EditOrderItem(int customerId, int? orderId, int? orderItemId, DataTable products, NpgsqlConnection conn)
        {
            _conn = conn;
            _orderId = orderId;
            _orderItemId = orderItemId;
            _customerId = customerId;


            InitializeComponent();

            //dgProducts.Visible = true;
            cbProducts.Visible = true;
            tbName.Visible = false;

            dgProducts.DataSource = products;

            _productList = (from DataRow dr in products.Rows
                               select new Product()
                               {
                                   Id = Convert.ToInt32(dr["id"]),
                                   Name = dr["Name"].ToString(),
                                   Price = decimal.Parse(dr["Price"].ToString()),
                                   RecipeIsReq = Boolean.Parse(dr["recipeisreq"].ToString())

                               }).ToList();

            cbProducts.DataSource = _productList;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "Id";

            if (_orderItemId.HasValue)
            {
                LoadOrderItem(_orderItemId.Value);
                LoadOrderItemRecipe(_orderItemId.Value);
            }

            LoadRecipes(_customerId);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_orderItemId.HasValue)
            {
                UpdateOrderItem();
            }
            else
            {
                CreateOrderItem();
            }
        }

        private void LoadOrderItemRecipe(int id)
        { 

            string sql = "SELECT r.* FROM Recipes as r inner join orderitems as oi on r.id = oi.recipeId" +
                " WHERE oi.id = @id";
            NpgsqlCommand command;
            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("id", id);

            dgvOIRecipe.DataSource = ExecuteReaderCommand(command, _conn);
        }
        private void LoadOrderItem(int id)
        {

            _conn.Open();

            string sql = "SELECT p.id, p.name, oi.price, oi.quantity FROM orderitems as oi inner join products as p on oi.productid = p.id" +
                " WHERE oi.id = @id";
            NpgsqlCommand command;
            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("id", id);


            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbProducts.SelectedValue = int.Parse(reader["id"].ToString());
                nPrice.Value = (decimal)reader["price"];
                nQty.Value = int.Parse(reader["quantity"].ToString());
                break;
            }
            command.Dispose();
            _conn.Close();
        }

        private void LoadRecipes(int customerId)
        {
            string sql = "SELECT * from recipes where customerid = @customerid";
            NpgsqlCommand command;
            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("customerid", customerId);


            dgvRecipes.DataSource = ExecuteReaderCommand(command, _conn);
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

        private void UpdateOrderItem()
        {
            lResultS.Visible = false;
            lResultF.Visible = false;
            _conn.Open();

            NpgsqlCommand command;

            string sql = "UPDATE orderitems set price = @price, quantity = @quantity, productid = @productid ";

            var index = cbProducts.SelectedIndex;
            if (_productList[index].RecipeIsReq && dgvRecipes.Visible)
            {
                sql = sql + ", recipeId = @recipeId ";
            }

            sql = sql + "where id = @id";

            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("price", nPrice.Value);
            command.Parameters.AddWithValue("productid", cbProducts.SelectedValue);
            command.Parameters.AddWithValue("quantity", nQty.Value);
            command.Parameters.AddWithValue("id", _orderItemId);

            if (_productList[index].RecipeIsReq && dgvRecipes.Visible)
            {
                command.Parameters.AddWithValue("recipeId", 
                    int.Parse(dgvRecipes.CurrentRow.Cells[0].Value.ToString()));
            }

            var result = command.ExecuteNonQuery();
            if (result == 1)
            {
                lResultS.Visible = true;
            }
            else
            {
                lResultF.Visible = true;

            }

            command.Dispose();
            _conn.Close();
        }

        private void CreateOrderItem()
        {
            string sql = "INSERT INTO public.orderItems(orderid, productid, price, quantity, recipeid) " +
                        "VALUES (@orderid, @productid, @price, @qty, @recipeid)";

           
            NpgsqlCommand command = new NpgsqlCommand(sql, _conn);
            _conn.Open();

            command.CommandText = sql;

            command.Parameters.AddWithValue("orderid", _orderId);
            //command.Parameters.AddWithValue("productid", dgProducts.CurrentRow.Cells[0].Value);
            command.Parameters.AddWithValue("productid", cbProducts.SelectedValue);
            command.Parameters.AddWithValue("price", nPrice.Value);
            command.Parameters.AddWithValue("qty", nQty.Value);

            var index = cbProducts.SelectedIndex;

            if (_productList[index].RecipeIsReq && dgvRecipes.Visible)
            {
                command.Parameters.AddWithValue("recipeId",
                    int.Parse(dgvRecipes.CurrentRow.Cells[0].Value.ToString()));
            }
            else
            {
                command.Parameters.AddWithValue("recipeId", DBNull.Value);
            }

            command.ExecuteNonQuery();

            command.Dispose();

            MessageBox.Show("Item was added to the Order. Form will be closed", "Order was updated");
            _conn.Close();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProducts.CurrentRow == null)
                return;

            nPrice.Value = (decimal)dgProducts.CurrentRow.Cells[3].Value;
        }

        private void EditOrderItem_Shown(object sender, EventArgs e)
        {

            dgProducts.ClearSelection();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbProducts.SelectedIndex;
            var price = _productList[index].Price;

            bChangeRecipe.Visible = _productList[index].RecipeIsReq;


            nPrice.Value = price;
        }

        private void bChangeRecipe_Click(object sender, EventArgs e)
        {
            lCR.Visible = true;
            dgvRecipes.Visible = true;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool RecipeIsReq { get; set; }
    }
}
