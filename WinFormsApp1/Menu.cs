using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            orders chg = new orders();
            chg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailOrder chg = new DetailOrder();
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
            importBill chg = new importBill();
            chg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DetailIp chg = new DetailIp();
            chg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login chg = new Login();
            chg.Show();
            this.Hide();
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
    }
}
