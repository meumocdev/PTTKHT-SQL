namespace WinFormsApp1
{
    partial class DetailIp
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label10 = new Label();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            button7 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            reset = new Button();
            texprice = new TextBox();
            label6 = new Label();
            textAMOUNT = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboproduct = new ComboBox();
            label9 = new Label();
            comboimport = new ComboBox();
            button8 = new Button();
            update = new Button();
            button10 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            shippmentid = new ComboBox();
            label3 = new Label();
            madon = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 666);
            panel1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkMagenta;
            label10.Location = new Point(716, 59);
            label10.Name = "label10";
            label10.Size = new Size(70, 18);
            label10.TabIndex = 27;
            label10.Text = "SEARCH";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(801, 55);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Lavender;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle5.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle6.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.GridColor = Color.Thistle;
            dataGridView2.Location = new Point(82, 113);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle7.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle7.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle8.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = Color.DarkMagenta;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(917, 308);
            dataGridView2.TabIndex = 25;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(857, 589);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(123, 31);
            button5.TabIndex = 22;
            button5.Text = "EXIT";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkMagenta;
            button7.Location = new Point(857, 441);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(123, 31);
            button7.TabIndex = 24;
            button7.Text = "INSTORAGE";
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Lavender;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkMagenta;
            button6.Location = new Point(857, 516);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(123, 31);
            button6.TabIndex = 23;
            button6.Text = "IMPORTBILL";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(shippmentid);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(madon);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(82, 441);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 189);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(reset);
            panel3.Controls.Add(texprice);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textAMOUNT);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboproduct);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(comboimport);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(update);
            panel3.Controls.Add(button10);
            panel3.Location = new Point(-1, -1);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(704, 189);
            panel3.TabIndex = 30;
            // 
            // reset
            // 
            reset.BackColor = Color.Lavender;
            reset.Cursor = Cursors.Hand;
            reset.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reset.ForeColor = Color.DarkMagenta;
            reset.Location = new Point(607, 150);
            reset.Margin = new Padding(3, 2, 3, 2);
            reset.Name = "reset";
            reset.Size = new Size(76, 28);
            reset.TabIndex = 31;
            reset.Text = "RESET";
            reset.TextAlign = ContentAlignment.TopCenter;
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // texprice
            // 
            texprice.Location = new Point(352, 137);
            texprice.Name = "texprice";
            texprice.Size = new Size(190, 27);
            texprice.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkMagenta;
            label6.Location = new Point(352, 99);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 29;
            label6.Text = "PriceImport";
            // 
            // textAMOUNT
            // 
            textAMOUNT.Location = new Point(352, 55);
            textAMOUNT.Name = "textAMOUNT";
            textAMOUNT.Size = new Size(213, 27);
            textAMOUNT.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkMagenta;
            label7.Location = new Point(352, 30);
            label7.Name = "label7";
            label7.Size = new Size(101, 18);
            label7.TabIndex = 27;
            label7.Text = "AmountImport";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkMagenta;
            label8.Location = new Point(26, 99);
            label8.Name = "label8";
            label8.Size = new Size(74, 18);
            label8.TabIndex = 26;
            label8.Text = "ProductID";
            // 
            // comboproduct
            // 
            comboproduct.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboproduct.ForeColor = Color.DarkMagenta;
            comboproduct.FormattingEnabled = true;
            comboproduct.Items.AddRange(new object[] { "DD01", "DD02", "VD02", "TL15", "TV14", "TV29" });
            comboproduct.Location = new Point(26, 136);
            comboproduct.Margin = new Padding(3, 2, 3, 2);
            comboproduct.Name = "comboproduct";
            comboproduct.Size = new Size(251, 26);
            comboproduct.TabIndex = 25;
            comboproduct.Text = "ProductID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkMagenta;
            label9.Location = new Point(26, 26);
            label9.Name = "label9";
            label9.Size = new Size(83, 18);
            label9.TabIndex = 2;
            label9.Text = "ImportBillID";
            // 
            // comboimport
            // 
            comboimport.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboimport.ForeColor = Color.DarkMagenta;
            comboimport.FormattingEnabled = true;
            comboimport.Items.AddRange(new object[] { "N001", "N002", "N003", "N004" });
            comboimport.Location = new Point(26, 54);
            comboimport.Margin = new Padding(3, 2, 3, 2);
            comboimport.Name = "comboimport";
            comboimport.Size = new Size(251, 26);
            comboimport.TabIndex = 3;
            comboimport.Text = "ImportBillID";
            // 
            // button8
            // 
            button8.BackColor = Color.Lavender;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkMagenta;
            button8.Location = new Point(607, 16);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(76, 28);
            button8.TabIndex = 19;
            button8.Text = "INSERT";
            button8.TextAlign = ContentAlignment.TopCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // update
            // 
            update.BackColor = Color.Lavender;
            update.Cursor = Cursors.Hand;
            update.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            update.ForeColor = Color.DarkMagenta;
            update.Location = new Point(607, 60);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Size = new Size(76, 28);
            update.TabIndex = 21;
            update.Text = "UPDATE";
            update.TextAlign = ContentAlignment.TopCenter;
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Lavender;
            button10.Cursor = Cursors.Hand;
            button10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.DarkMagenta;
            button10.Location = new Point(607, 105);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(76, 28);
            button10.TabIndex = 20;
            button10.Text = "DELETE";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkMagenta;
            label5.Location = new Point(375, 99);
            label5.Name = "label5";
            label5.Size = new Size(83, 18);
            label5.TabIndex = 29;
            label5.Text = "ImportBillID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(375, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(375, 26);
            label4.Name = "label4";
            label4.Size = new Size(83, 18);
            label4.TabIndex = 27;
            label4.Text = "ImportBillID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 26;
            label2.Text = "ProductID";
            // 
            // shippmentid
            // 
            shippmentid.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            shippmentid.ForeColor = Color.DarkMagenta;
            shippmentid.FormattingEnabled = true;
            shippmentid.Items.AddRange(new object[] { "DD01", "DD02", "VD02", "TV14", "TV29" });
            shippmentid.Location = new Point(26, 136);
            shippmentid.Margin = new Padding(3, 2, 3, 2);
            shippmentid.Name = "shippmentid";
            shippmentid.Size = new Size(271, 26);
            shippmentid.TabIndex = 25;
            shippmentid.Text = "ProductID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(26, 26);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 2;
            label3.Text = "ImportBillID";
            // 
            // madon
            // 
            madon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            madon.ForeColor = Color.DarkMagenta;
            madon.FormattingEnabled = true;
            madon.Items.AddRange(new object[] { "N001", "N002", "N003", "N004" });
            madon.Location = new Point(26, 54);
            madon.Margin = new Padding(3, 2, 3, 2);
            madon.Name = "madon";
            madon.Size = new Size(271, 26);
            madon.TabIndex = 3;
            madon.Text = "ImportBillID";
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(607, 26);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(76, 28);
            button1.TabIndex = 19;
            button1.Text = "INSERT";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(607, 89);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(76, 28);
            button3.TabIndex = 21;
            button3.Text = "UPDATE";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(607, 136);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(76, 28);
            button2.TabIndex = 20;
            button2.Text = "DELETE";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1080, 53);
            label1.TabIndex = 0;
            label1.Text = "DETAILBILLIMPORT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DetailIp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 656);
            Controls.Add(panel1);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailIp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += DetailIp_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private ComboBox madon;
        private Label label1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Label label2;
        private ComboBox shippmentid;
        private Panel panel3;
        private TextBox texprice;
        private Label label6;
        private TextBox textAMOUNT;
        private Label label7;
        private Label label8;
        private ComboBox comboproduct;
        private Label label9;
        private ComboBox comboimport;
        private Button button8;
        private Button update;
        private Button button10;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private Button reset;
        private Label label10;
    }
}