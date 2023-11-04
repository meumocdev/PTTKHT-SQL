using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;

namespace WinFormsApp1
{
    partial class DetailOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
            SupplierID = new ComboBox();
            ShippmentID = new TextBox();
            button5 = new Button();
            button4 = new Button();
            label5 = new Label();
            AmountOrder = new TextBox();
            button1 = new Button();
            label10 = new Label();
            label3 = new Label();
            button7 = new Button();
            productid = new ComboBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            button6 = new Button();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(10, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 482);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(556, 45);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 35;
            label4.Text = "SEARCH";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(622, 43);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 34;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(711, 391);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(103, 34);
            button2.TabIndex = 27;
            button2.Text = "ORDER";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(SupplierID);
            panel2.Controls.Add(ShippmentID);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(AmountOrder);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(productid);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(57, 250);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 207);
            panel2.TabIndex = 18;
            // 
            // SupplierID
            // 
            SupplierID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SupplierID.ForeColor = Color.DarkMagenta;
            SupplierID.FormattingEnabled = true;
            SupplierID.Items.AddRange(new object[] { "C01", "C02", "C03", "C04", "C05", "C06", "C07" });
            SupplierID.Location = new Point(326, 115);
            SupplierID.Margin = new Padding(3, 2, 3, 2);
            SupplierID.Name = "SupplierID";
            SupplierID.Size = new Size(232, 23);
            SupplierID.TabIndex = 41;
            SupplierID.Text = "SupplierID";
            // 
            // ShippmentID
            // 
            ShippmentID.BorderStyle = BorderStyle.FixedSingle;
            ShippmentID.Location = new Point(10, 34);
            ShippmentID.Margin = new Padding(2);
            ShippmentID.Name = "ShippmentID";
            ShippmentID.Size = new Size(232, 23);
            ShippmentID.TabIndex = 40;
            ShippmentID.TextChanged += ShippmentID_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(326, 162);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(84, 30);
            button5.TabIndex = 39;
            button5.Text = "DELETE";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkMagenta;
            button4.Location = new Point(188, 162);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(84, 30);
            button4.TabIndex = 38;
            button4.Text = "UPDATE";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCyan;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkMagenta;
            label5.Location = new Point(10, 92);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 34;
            label5.Text = "AmountOrder";
            // 
            // AmountOrder
            // 
            AmountOrder.BorderStyle = BorderStyle.FixedSingle;
            AmountOrder.Location = new Point(10, 117);
            AmountOrder.Margin = new Padding(2);
            AmountOrder.Name = "AmountOrder";
            AmountOrder.Size = new Size(232, 23);
            AmountOrder.TabIndex = 33;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(474, 162);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(84, 30);
            button1.TabIndex = 28;
            button1.Text = "RESET";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightCyan;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkMagenta;
            label10.Location = new Point(10, 10);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 31;
            label10.Text = "ShippmentID";
            label10.Click += label10_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(326, 10);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "ProductID";
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkMagenta;
            button7.Location = new Point(52, 162);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(84, 30);
            button7.TabIndex = 27;
            button7.Text = "ADD";
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // productid
            // 
            productid.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productid.ForeColor = Color.DarkMagenta;
            productid.FormattingEnabled = true;
            productid.Items.AddRange(new object[] { "DD01", "DD02", "TL15", "TL90", "TV14", "TV21", "TV29", "VD01", "VD02" });
            productid.Location = new Point(326, 34);
            productid.Margin = new Padding(3, 2, 3, 2);
            productid.Name = "productid";
            productid.Size = new Size(232, 23);
            productid.TabIndex = 3;
            productid.Text = "ProductID";
            productid.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkMagenta;
            label6.Location = new Point(4, 10);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Thistle;
            dataGridView1.Location = new Point(57, 73);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle4.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = Color.DarkMagenta;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(758, 160);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(836, 3);
            label2.Name = "label2";
            label2.Size = new Size(24, 24);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(864, 41);
            label1.TabIndex = 0;
            label1.Text = "DETAILORDER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.BackColor = Color.Lavender;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkMagenta;
            button6.Location = new Point(711, 321);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(103, 34);
            button6.TabIndex = 26;
            button6.Text = "INSTORAGE PAGE";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(711, 261);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(103, 34);
            button3.TabIndex = 25;
            button3.Text = "DETAILBILLIMPORT";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // DetailOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(885, 504);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ADD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox productid;
        private Label label6;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button3;
        private Button button1;
        private Button button7;
        private Button button6;
        private Label label10;
        private Label label5;
        private TextBox AmountOrder;
        private Button button2;
        private Button button5;
        private Button button4;
        private Label label4;
        private TextBox textBox1;
        private TextBox ShippmentID;
        private ComboBox SupplierID;
        private BindingSource bindingSource1;
    }
}

