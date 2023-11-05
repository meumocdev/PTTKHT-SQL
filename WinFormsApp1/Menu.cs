using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Import chg = new Import();
            chg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailImport chg = new DetailImport();
            chg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Depot chg = new Depot();
            chg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPr chg = new AddPr();
            chg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login chg = new Login();
            chg.Show();
            this.Hide();


            Close();
            User.Logout();

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sell chg = new Sell();
            chg.Show();
            this.Hide();

        }


        private void button8_Click(object sender, EventArgs e)
        {
            DetailEp chg = new DetailEp();
            chg.Show();
            this.Hide();
        }
        int tat = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            tat = 1;
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddPr chg = new AddPr();
            chg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (User.CurrentUser.IsImport)
            {
                button7.Enabled = false;
                button8.Enabled = false;
            }

            if (User.CurrentUser.IsSale)
            {
                button3.Enabled = false;
                button1.Enabled = false;
            }


            if (User.CurrentUser.IsAdmin)
                lbl_Role.Text = "Current User: Admin";
            else if (User.CurrentUser.IsSale)
                lbl_Role.Text = "Current User: Sale";
            else if (User.CurrentUser.IsImport)
                lbl_Role.Text = "Current User: Import";
        }

        

        private void lbl_Role_Click(object sender, EventArgs e)
        {

        }
    }
}
