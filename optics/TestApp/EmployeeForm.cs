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
    public partial class EmployeeForm : Form
    {
        private int? _employeeId;
        private NpgsqlConnection _conn;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(NpgsqlConnection conn)
        {
            _conn = conn;
            InitializeComponent();
            LoadEmployees();
            panel1.Visible = false;

        }

        private void LoadEmployees() 
        {
            string sql = "Select * from employees order by id";

            NpgsqlCommand command;
            command = new NpgsqlCommand(sql, _conn);


            ExecuteAndFill(command);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            var employeeRaw = gvReport.CurrentRow;

            _employeeId = int.Parse(employeeRaw.Cells[0].Value.ToString());

            tbFirstName.Text = employeeRaw.Cells[1].Value.ToString();
            tbLastName.Text = employeeRaw.Cells[2].Value.ToString();
            dpHiringData.Value = DateTime.Parse(employeeRaw.Cells[3].Value.ToString());
            tbPhone.Text = employeeRaw.Cells[4].Value.ToString();
            tbEmail.Text = employeeRaw.Cells[5].Value.ToString();            
            tbContact.Text = employeeRaw.Cells[6].Value.ToString();


            panel1.Visible = true;

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

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {

            if (ModelIsValid())
            {
                return;
            }

            panel1.Visible = false;

            if (_employeeId.HasValue)
            {
                //edit recipt
                string sql = "update Employees set firstname=@firstname, lastname=@lastname, hiringdate=@hiringdate, " +
                    "email=@email, phone=@phone, contract=@contract " +
                    "where id = @id";
                NpgsqlCommand command;

                command = new NpgsqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", _employeeId.Value);
                command.Parameters.AddWithValue("firstname", tbFirstName.Text);
                command.Parameters.AddWithValue("lastname", tbLastName.Text);
                command.Parameters.AddWithValue("hiringdate", dpHiringData.Value.Date);
                command.Parameters.AddWithValue("email", tbEmail.Text);
                command.Parameters.AddWithValue("phone", tbPhone.Text);
                command.Parameters.AddWithValue("contract", tbContact.Text);

                ExecuteScalar(command);

                _employeeId = null;
            }
            else
            {
                string sql = "insert into Employees (firstname, lastname, hiringdate,email,phone,contract)" +
                    "values (@firstname, @lastname, @hiringdate, @email, @phone, @contract)";
                NpgsqlCommand command;

                command = new NpgsqlCommand(sql, _conn);
                command.Parameters.AddWithValue("firstname", tbFirstName.Text);
                command.Parameters.AddWithValue("lastname", tbLastName.Text);
                command.Parameters.AddWithValue("hiringdate", dpHiringData.Value.Date);
                command.Parameters.AddWithValue("email", tbEmail.Text);
                command.Parameters.AddWithValue("phone", tbPhone.Text);
                command.Parameters.AddWithValue("contract", tbContact.Text);

                ExecuteScalar(command);



            }

            LoadEmployees();
        }

        private void ExecuteScalar(NpgsqlCommand comm)
        {
            NpgsqlCommand command = comm;
            try
            {
                _conn.Open();

                var result = command.ExecuteNonQuery();

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

        private void bAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            _employeeId = null;

            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbContact.Text = "";
        }

        private bool ModelIsValid()
        {
            lErrors.Visible = false;
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

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                errorStr.Append("Phone could not be empty");
                errorStr.AppendLine();
            }

            if (string.IsNullOrEmpty(tbContact.Text))
            {
                errorStr.Append("Contract could not be empty");
                errorStr.AppendLine();
            }
            if (dpHiringData.Value > DateTime.Now)
            {
                errorStr.Append("Hiring date is not valid");
                errorStr.AppendLine();
            }

            lErrors.Text = errorStr.ToString();
            lErrors.Visible = true;

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
