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
    public partial class EditCustomerForm : Form
    {
        private int _customerId;
        private NpgsqlConnection _conn;
        public EditCustomerForm()
        {
            InitializeComponent();
        }

        public EditCustomerForm(int customerId, NpgsqlConnection conn)
        {
            _customerId = customerId;
            _conn = conn;

            InitializeComponent();
            LoadCustomer(_customerId);
        }

        public EditCustomerForm(NpgsqlConnection conn)
        {
            _conn = conn;

            InitializeComponent();
            LoadCustomer(_customerId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ModelIsValid())
            {
                return;
            }

            SaveCustomer(_customerId == 0);
        }

        private void LoadCustomer(int id)
        {

            _conn.Open();

            string sql = "SELECT * FROM public.customers WHERE id = @customerid";
            NpgsqlCommand command;
            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("customerid", id);


            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var date = DateTime.Now;

                DateTime.TryParse(reader["dob"].ToString(), out date);

                tbFirstName.Text = reader["firstname"].ToString();
                tbLastName.Text = reader["lastname"].ToString();
                tbAddress.Text = reader["address"].ToString();
                tbPhone.Text = reader["phone"].ToString();
                tbCountry.Text = reader["country"].ToString();
                tbEmail.Text = reader["email"].ToString();

                if (date.Year < 1925)
                {
                    date = DateTime.Now;
                }
                dpDoB.Value = date;
                break;
            }
            command.Dispose();
            _conn.Close();
        }

        private void SaveCustomer(bool isNew)
        {

            lResultS.Visible = false;
            lResultF.Visible = false;
            _conn.Open();

            // Define a query returning a single row result set
            //NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM information_schema.tables", conn);
            NpgsqlCommand command;
            string sql;

            if (isNew)
            {
                sql = "INSERT INTO public.customers(firstName, LastName, Phone, Email, DoB, Address, Country, CreatedDate) " +
                "VALUES (@firstName, @lastName, @phone, @email, @dob, @address, @country, @createdDate)";
                command = new NpgsqlCommand(sql, _conn);
                command.Parameters.AddWithValue("createdDate", DateTime.Now);

            }
            else
            {
                sql = "UPDATE customers set firstName = @firstName, lastName = @lastName, phone = @phone," +
                " email = @email, dob = @dob, address = @address, country = @country where id = @id";
                command = new NpgsqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", _customerId);
            }



            command.Parameters.AddWithValue("firstName", tbFirstName.Text);
            command.Parameters.AddWithValue("lastName", tbLastName.Text);
            command.Parameters.AddWithValue("phone", tbPhone.Text);
            command.Parameters.AddWithValue("email", tbEmail.Text);
            command.Parameters.AddWithValue("dob", dpDoB.Value.Date);
            command.Parameters.AddWithValue("address", tbAddress.Text);
            command.Parameters.AddWithValue("country", tbCountry.Text);

            var result = command.ExecuteNonQuery();
            if (result == 1)
            {
                lResultS.Visible = true;
                if (isNew)
                {
                    FormClean();
                }
            }
            else
            {
                lResultF.Visible = true;

            }

            command.Dispose();
            _conn.Close();
        }

        private void lResultS_Click(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dpDoB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DoB_Click(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lResultF_Click(object sender, EventArgs e)
        {

        }

        private void FormClean()
        {
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbCountry.Text = "";
            tbEmail.Text = "";
            dpDoB.Value = DateTime.Now;
        }

        private bool ModelIsValid()
        {
            lResultF.Visible = false;
            var errorStr = new StringBuilder();

            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                errorStr.Append("First Name could not be empty");
                errorStr.AppendLine();
            }

            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                errorStr.Append("Last Name could not be empty");
                errorStr.AppendLine();
            }

            if (!IsValidEmail(tbEmail.Text))
            {
                errorStr.Append("Email is not valid or empty");
                errorStr.AppendLine();
            }

            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                errorStr.Append("Address could not be empty");
                errorStr.AppendLine();
            }

            if (string.IsNullOrEmpty(tbCountry.Text))
            {
                errorStr.Append("Country could not be empty");
                errorStr.AppendLine();
            }

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                errorStr.Append("Phone could not be empty");
                errorStr.AppendLine();
            }
            if (dpDoB.Value > DateTime.Now)
            {
                errorStr.Append("Birthaday is not valid");
                errorStr.AppendLine();
            }

            

            lResultF.Text = errorStr.ToString();
            lResultF.Visible = true;

            return errorStr.Length > 0;
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
