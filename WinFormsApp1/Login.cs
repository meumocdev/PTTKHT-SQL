using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox4.Text == "123456789")
            {
                ConnectData c = new ConnectData();
                c.connect();

                // Check để xem có đúng là user mong muốn hay không
                string query = "SELECT SYSTEM_USER;";
                SqlCommand command = new SqlCommand(query, c.conn);
                string currentUser = (string)command.ExecuteScalar();
                MessageBox.Show(string.Format("Current User: {0}", currentUser));

                User.CurrentUser.IsAdmin = textBox1.Text == "Admin";

                Menu menu = new Menu();
                this.Hide();
                menu.Show();

            }

            else if (textBox1.Text == "Sale" && textBox4.Text == "123456789")
            {
                ConnectData c = new ConnectData();
                c.connectSale();

                // Check để xem có đúng là user mong muốn hay không
                string query = "SELECT SYSTEM_USER;";
                SqlCommand command = new SqlCommand(query, c.conn);
                string currentUser = (string)command.ExecuteScalar();
                MessageBox.Show(string.Format("Current User: {0}", currentUser));

                User.CurrentUser.IsSale = textBox1.Text == "Sale";

                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }

            else if (textBox1.Text == "Import" && textBox4.Text == "123456789")
            {
                ConnectData c = new ConnectData();
                c.connectImport();

                // Check để xem có đúng là user mong muốn hay không
                string query = "SELECT SYSTEM_USER;";
                SqlCommand command = new SqlCommand(query, c.conn);
                string currentUser = (string)command.ExecuteScalar();
                MessageBox.Show(string.Format("Current User: {0}", currentUser));

                User.CurrentUser.IsImport = textBox1.Text == "Import";

                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
                MessageBox.Show("Đăng nhập không thành công");


        }


        private void button2_Leave(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int tat = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            tat = 1;
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tat == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn FormClosing không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
