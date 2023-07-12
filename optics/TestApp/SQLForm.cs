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
    public partial class SQLForm : Form
    {
        private NpgsqlConnection _conn;

        public SQLForm()
        {
            InitializeComponent();

        }

        public SQLForm(NpgsqlConnection conn)
        {
            InitializeComponent();

            _conn = conn;
        }

        private void bExecuteSql_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command;
            try
            {

                _conn.Open();

                string sql = textBox1.Text;
                
                command = new NpgsqlCommand(sql, _conn);

                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgData.DataSource = dt;
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

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dgData.DataSource = null;
        }
    }
}
