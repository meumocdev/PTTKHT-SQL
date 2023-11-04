namespace WinFormsApp1
{
    partial class AddPr
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label10 = new Label();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            button7 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ExportPriceItem = new TextBox();
            label11 = new Label();
            ProductName = new TextBox();
            ProductID = new TextBox();
            reset = new Button();
            ImportPriceItem = new TextBox();
            label6 = new Label();
            Currency = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button8 = new Button();
            update = new Button();
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
            panel1.Size = new Size(945, 500);
            panel1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkMagenta;
            label10.Location = new Point(626, 44);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 27;
            label10.Text = "SEARCH";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(701, 41);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Lavender;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.GridColor = Color.Thistle;
            dataGridView2.Location = new Point(72, 85);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle4.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = Color.DarkMagenta;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(802, 231);
            dataGridView2.TabIndex = 25;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(795, 430);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(79, 29);
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
            button7.Location = new Point(795, 336);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(79, 31);
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
            button6.Location = new Point(795, 381);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(79, 31);
            button6.TabIndex = 23;
            button6.Text = "MENU";
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
            panel2.Location = new Point(72, 331);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 152);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ExportPriceItem);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(ProductName);
            panel3.Controls.Add(ProductID);
            panel3.Controls.Add(reset);
            panel3.Controls.Add(ImportPriceItem);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(Currency);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(update);
            panel3.Location = new Point(-1, -1);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 152);
            panel3.TabIndex = 30;
            // 
            // ExportPriceItem
            // 
            ExportPriceItem.Location = new Point(395, 100);
            ExportPriceItem.Margin = new Padding(3, 2, 3, 2);
            ExportPriceItem.Name = "ExportPriceItem";
            ExportPriceItem.Size = new Size(167, 23);
            ExportPriceItem.TabIndex = 35;
            ExportPriceItem.TextChanged += ExportPriceItem_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkMagenta;
            label11.Location = new Point(285, 102);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 34;
            label11.Text = "ExportPriceItem";
            // 
            // ProductName
            // 
            ProductName.Location = new Point(19, 90);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(236, 23);
            ProductName.TabIndex = 33;
            // 
            // ProductID
            // 
            ProductID.Location = new Point(19, 35);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(195, 23);
            ProductID.TabIndex = 32;
            ProductID.TextChanged += ProductID_TextChanged;
            // 
            // reset
            // 
            reset.BackColor = Color.Lavender;
            reset.Cursor = Cursors.Hand;
            reset.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reset.ForeColor = Color.DarkMagenta;
            reset.Location = new Point(581, 102);
            reset.Margin = new Padding(3, 2, 3, 2);
            reset.Name = "reset";
            reset.Size = new Size(66, 29);
            reset.TabIndex = 31;
            reset.Text = "RESET";
            reset.TextAlign = ContentAlignment.TopCenter;
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // ImportPriceItem
            // 
            ImportPriceItem.Location = new Point(395, 57);
            ImportPriceItem.Margin = new Padding(3, 2, 3, 2);
            ImportPriceItem.Name = "ImportPriceItem";
            ImportPriceItem.Size = new Size(167, 23);
            ImportPriceItem.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkMagenta;
            label6.Location = new Point(285, 65);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 29;
            label6.Text = "ImportPriceItem";
            // 
            // Currency
            // 
            Currency.Location = new Point(395, 13);
            Currency.Margin = new Padding(3, 2, 3, 2);
            Currency.Name = "Currency";
            Currency.Size = new Size(144, 23);
            Currency.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkMagenta;
            label7.Location = new Point(285, 20);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 27;
            label7.Text = "Currency";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkMagenta;
            label8.Location = new Point(19, 65);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 26;
            label8.Text = "ProductName";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkMagenta;
            label9.Location = new Point(19, 12);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 2;
            label9.Text = "ProductID";
            // 
            // button8
            // 
            button8.BackColor = Color.Lavender;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkMagenta;
            button8.Location = new Point(581, 13);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(66, 28);
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
            update.Location = new Point(581, 60);
            update.Margin = new Padding(3, 2, 3, 2);
            update.Name = "update";
            update.Size = new Size(66, 28);
            update.TabIndex = 21;
            update.Text = "UPDATE";
            update.TextAlign = ContentAlignment.TopCenter;
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkMagenta;
            label5.Location = new Point(328, 74);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 29;
            label5.Text = "ImportBillID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 40);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(328, 20);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 27;
            label4.Text = "ImportBillID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(23, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 26;
            label2.Text = "ProductID";
            // 
            // shippmentid
            // 
            shippmentid.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            shippmentid.ForeColor = Color.DarkMagenta;
            shippmentid.FormattingEnabled = true;
            shippmentid.Items.AddRange(new object[] { "DD01", "DD02", "VD02", "TV14", "TV29" });
            shippmentid.Location = new Point(23, 102);
            shippmentid.Margin = new Padding(3, 2, 3, 2);
            shippmentid.Name = "shippmentid";
            shippmentid.Size = new Size(238, 23);
            shippmentid.TabIndex = 25;
            shippmentid.Text = "ProductID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(23, 20);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "ImportBillID";
            // 
            // madon
            // 
            madon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            madon.ForeColor = Color.DarkMagenta;
            madon.FormattingEnabled = true;
            madon.Items.AddRange(new object[] { "N001", "N002", "N003", "N004" });
            madon.Location = new Point(23, 40);
            madon.Margin = new Padding(3, 2, 3, 2);
            madon.Name = "madon";
            madon.Size = new Size(238, 23);
            madon.TabIndex = 3;
            madon.Text = "ImportBillID";
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(531, 20);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 21);
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
            button3.Location = new Point(531, 67);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(66, 21);
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
            button2.Location = new Point(531, 102);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(66, 21);
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
            label1.Size = new Size(945, 40);
            label1.TabIndex = 0;
            label1.Text = "ADD PRODUCTS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddPr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 492);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPr";
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
        private TextBox ImportPriceItem;
        private Label label6;
        private TextBox Currency;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button8;
        private Button update;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private Button reset;
        private Label label10;
        private TextBox ProductID;
        private TextBox ProductName;
        private Label label11;
        private TextBox ExportPriceItem;
    }
}