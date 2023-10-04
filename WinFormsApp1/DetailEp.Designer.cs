namespace WinFormsApp1
{
    partial class DetailEp
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
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ImportBillID = new DataGridViewTextBoxColumn();
            Tenhang = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            Tongtien = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 534);
            panel1.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkMagenta;
            button7.Location = new Point(739, 366);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(108, 26);
            button7.TabIndex = 24;
            button7.Text = "KHO";
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
            button6.Location = new Point(616, 366);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(108, 26);
            button6.TabIndex = 23;
            button6.Text = "BÁN HÀNG";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(739, 418);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(108, 26);
            button5.TabIndex = 22;
            button5.Text = "THOÁT";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(739, 312);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(108, 26);
            button3.TabIndex = 21;
            button3.Text = "SỬA";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(616, 418);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 26);
            button2.TabIndex = 20;
            button2.Text = "XÓA";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(616, 312);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 26);
            button1.TabIndex = 19;
            button1.Text = "THÊM";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(88, 312);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 132);
            panel2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 20);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(18, 62);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã đơn bán";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.DarkMagenta;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DD01", "DD02", "TL15", "TL90", "TV14", "TV21", "TV29", "VD01", "VD02" });
            comboBox1.Location = new Point(122, 62);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "nhập mã";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(18, 20);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày bán";
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkMagenta;
            button4.Location = new Point(385, 40);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(81, 26);
            button4.TabIndex = 17;
            button4.Text = "TÌM KIẾM";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ImportBillID, Tenhang, soluong, Tongtien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Thistle;
            dataGridView1.Location = new Point(88, 80);
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
            dataGridView1.Size = new Size(759, 199);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ImportBillID
            // 
            ImportBillID.HeaderText = "ImportBillID";
            ImportBillID.MinimumWidth = 6;
            ImportBillID.Name = "ImportBillID";
            ImportBillID.Width = 110;
            // 
            // Tenhang
            // 
            Tenhang.DataPropertyName = "Tenhang";
            Tenhang.HeaderText = "ProductID";
            Tenhang.MinimumWidth = 6;
            Tenhang.Name = "Tenhang";
            Tenhang.Width = 125;
            // 
            // soluong
            // 
            soluong.DataPropertyName = "soluong";
            soluong.HeaderText = "AmountImport";
            soluong.MinimumWidth = 6;
            soluong.Name = "soluong";
            soluong.Width = 125;
            // 
            // Tongtien
            // 
            Tongtien.DataPropertyName = "Tongtien";
            Tongtien.HeaderText = "PriceImport";
            Tongtien.MinimumWidth = 6;
            Tongtien.Name = "Tongtien";
            Tongtien.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(335, 22);
            label1.Name = "label1";
            label1.Size = new Size(238, 24);
            label1.TabIndex = 0;
            label1.Text = "CHI TIẾT ĐƠN BÁN HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // DetailEp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 459);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailEp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += DetailEp_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn ImportBillID;
        private DataGridViewTextBoxColumn Tenhang;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn Tongtien;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
    }
}