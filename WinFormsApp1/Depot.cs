using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Depot : Form
    {
        public Depot()
        {
            InitializeComponent();
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
    }
}
