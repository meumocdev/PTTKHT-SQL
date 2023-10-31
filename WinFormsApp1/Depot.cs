using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Depot : Form
    {
        public Depot()
        {
            InitializeComponent();
            load();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-S7G583VS\SQLEXPRESS;Initial Catalog=Storage;Integrated Security=True");
        private void openCon()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

        }
        private void closeCon()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        private Boolean Exe(string cmd)
        {
            openCon();
            Boolean check;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(cmd, con);

                sqlCommand.ExecuteNonQuery();
                check = true;

            }
            catch (Exception ex)
            {
                check = false;
            }
            closeCon();
            return check;
        }
        private DataTable Red(string cmd)
        {
            openCon();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(cmd, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw;

            }
            closeCon();
            return dt;

        }

        private void load()
        {
            DataTable dt = Red("Select * from PRODUCT");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Sell sl = new Sell();
            sl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADD ad = new ADD();
            ad.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Product (ProductID,ProductName,Currency,Percents) VALUES ('" + textId.Text + "','" + textName.Text + "','" + texrdonvi.Text + "'," + Convert.ToInt32(textphantram.Text) + ")";
            Exe(query);
            load();
            Reset();
        }
        void Reset()
        {
            textId.Clear();

            textId.Focus();

            textName.Clear();

            textphantram.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
