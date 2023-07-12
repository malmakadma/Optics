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
    public partial class RecipeForm : Form
    {
        private int _customerId;
        private int? _reciptId;
        private NpgsqlConnection _conn;
        public RecipeForm()
        {
            InitializeComponent();
        }

        public RecipeForm(int id, NpgsqlConnection conn)
        {
            _customerId = id;
            _conn = conn;
            InitializeComponent();
            LoadRecipes();

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            _reciptId = int.Parse(dgvRecipts.CurrentRow.Cells[0].Value.ToString());

            nDP.Value = decimal.Parse(dgvRecipts.CurrentRow.Cells[3].Value.ToString());
            nR.Value = decimal.Parse(dgvRecipts.CurrentRow.Cells[4].Value.ToString());
            nSPH.Value = decimal.Parse(dgvRecipts.CurrentRow.Cells[5].Value.ToString());
            nCYL.Value = decimal.Parse(dgvRecipts.CurrentRow.Cells[6].Value.ToString());
            nAX.Value = decimal.Parse(dgvRecipts.CurrentRow.Cells[7].Value.ToString());
            nADD.Value = decimal.Parse(dgvRecipts.CurrentRow.Cells[8].Value.ToString());
            nBAS.Value = decimal.Parse(dgvRecipts.CurrentRow.Cells[9].Value.ToString());


            panel1.Visible = true;
        }

        private void LoadRecipes()
        {
            string sql = "Select * from Recipes as r where r.CustomerId = @customerId";
            NpgsqlCommand command;

            command = new NpgsqlCommand(sql, _conn);
            command.Parameters.AddWithValue("customerId", _customerId);

            ExecuteAndFill(command);
        }

        private void ExecuteAndFill(NpgsqlCommand comm)
        {
            NpgsqlCommand command = comm;
            dgvRecipts.DataSource = null;
            try
            {

                _conn.Open();

                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvRecipts.DataSource = dt;
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

        private void ExecuteScalar(NpgsqlCommand comm)
        {
            NpgsqlCommand command = comm;
            dgvRecipts.DataSource = null;
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

        private void bSave_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

            if (_reciptId.HasValue)
            {
                //edit recipt
                string sql = "update Recipes set dp=@dp, r=@r, sph=@sph, cyl=@cyl, ax=@ax, add=@add, bas=@bas " +
                    "where id = @id";
                NpgsqlCommand command;

                command = new NpgsqlCommand(sql, _conn);
                command.Parameters.AddWithValue("id", _reciptId);
                command.Parameters.AddWithValue("dp", nDP.Value);
                command.Parameters.AddWithValue("r", nR.Value);
                command.Parameters.AddWithValue("sph", nSPH.Value);
                command.Parameters.AddWithValue("cyl", nCYL.Value);
                command.Parameters.AddWithValue("ax", nAX.Value);
                command.Parameters.AddWithValue("add", nADD.Value);
                command.Parameters.AddWithValue("bas", nBAS.Value);

                ExecuteScalar(command);
            }
            else
            {
                //create new
                string sql = "INSERT INTO public.Recipes(dp, r, sph, cyl, ax, add, bas, createddate, customerid) " +
                "VALUES (@dp, @r, @sph,@cyl, @ax, @add, @bas, @createddate, @customerid)";
                NpgsqlCommand command;

                command = new NpgsqlCommand(sql, _conn);
                command.Parameters.AddWithValue("dp", nDP.Value);
                command.Parameters.AddWithValue("r", nR.Value);
                command.Parameters.AddWithValue("sph", nSPH.Value);
                command.Parameters.AddWithValue("cyl", nCYL.Value);
                command.Parameters.AddWithValue("ax", nAX.Value);
                command.Parameters.AddWithValue("add", nADD.Value);
                command.Parameters.AddWithValue("bas", nBAS.Value);
                command.Parameters.AddWithValue("createddate", DateTime.Now.Date);
                command.Parameters.AddWithValue("customerid", _customerId);

                ExecuteScalar(command);

            }

            LoadRecipes();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            nDP.Value = 0;
            nR.Value = 0;
            nSPH.Value = 0;
            nCYL.Value = 0;
            nAX.Value = 0;
            nADD.Value = 0;
            nBAS.Value = 0;

            panel1.Visible = true;
            _reciptId = null;
        }
    }
}
