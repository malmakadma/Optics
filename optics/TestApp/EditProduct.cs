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
    public partial class EditProduct : Form
    {
        private int _productId;
        private NpgsqlConnection _conn;
        public EditProduct()
        {
            InitializeComponent();
        }

        public EditProduct(int? id, NpgsqlConnection conn)
        {
            _productId = id.HasValue ? id.Value : 0;
            _conn = conn;
            InitializeComponent();

            if (_productId>0)
            {
                LoadProduct(_productId);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ModelIsValid())
            {
                return;
            }

            if (_productId > 0)
            {
                UpdateProduct();
            }
            else
            {
                InsertProduct();
            }
            
        }

        private bool ModelIsValid()
        {
            lResultF.Visible = false;
            var errorStr = new StringBuilder();

            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorStr.Append("Name could not be empty");
                errorStr.AppendLine();
            }

            

            if (string.IsNullOrEmpty(tbCountry.Text))
            {
                errorStr.Append("Country could not be empty");
                errorStr.AppendLine();
            }

            if (string.IsNullOrEmpty(tbArticle.Text))
            {
                errorStr.Append("Article could not be empty");
                errorStr.AppendLine();
            }

            lResultF.Text = errorStr.ToString();
            lResultF.Visible = true;

            return errorStr.Length > 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadProduct(int id)
        {

            _conn.Open();

            string sql = "SELECT * FROM public.Products WHERE id = @id";
            NpgsqlCommand command;
            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("id", id);


            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbName.Text = reader["name"].ToString();
                tbDescription.Text = reader["description"].ToString();
                tbCountry.Text = reader["country_origin"].ToString();
                tbArticle.Text = reader["article"].ToString();
                nPrice.Value = (decimal)reader["price"];
                cbRecipeIsReq.Checked = Boolean.Parse(reader["recipeisreq"].ToString());
            }
            command.Dispose();
            _conn.Close();
        }

        private void UpdateProduct()
        {
            lResultS.Visible = false;
            lResultF.Visible = false;
            _conn.Open();

            NpgsqlCommand command;

            string sql = "UPDATE products set name = @name, description = @description, country_origin = @country," +
                " article = @article, price = @price, recipeisreq = @recipeisreq where id = @id";

            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("name", tbName.Text);
            command.Parameters.AddWithValue("description", tbDescription.Text);
            command.Parameters.AddWithValue("country", tbCountry.Text);
            command.Parameters.AddWithValue("article", tbArticle.Text);
            command.Parameters.AddWithValue("price", nPrice.Value);
            command.Parameters.AddWithValue("id", _productId);
            command.Parameters.AddWithValue("recipeisreq", cbRecipeIsReq.Checked);

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

        private void InsertProduct()
        {
            lResultS.Visible = false;
            lResultF.Visible = false;
            _conn.Open();

            NpgsqlCommand command;

            string sql = "INSERT INTO products(name,description,country_origin,article,price, recipeisreq) VALUES(@name, @description, @country," +
                " @article, @price, @recipeisreq)";

            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("name", tbName.Text);
            command.Parameters.AddWithValue("description", tbDescription.Text);
            command.Parameters.AddWithValue("country", tbCountry.Text);
            command.Parameters.AddWithValue("article", tbArticle.Text);
            command.Parameters.AddWithValue("price", nPrice.Value);
            command.Parameters.AddWithValue("recipeisreq", cbRecipeIsReq.Checked);



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
    }
}
