namespace WinFormsApp1
{
    partial class ADD
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
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
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
            ShippmentID = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Location = new Point(12, 15);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 642);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(636, 60);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 35;
            label4.Text = "SEARCH";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(711, 57);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 34;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(813, 521);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 46);
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
            panel2.Location = new Point(65, 333);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 260);
            panel2.TabIndex = 18;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(373, 216);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(96, 29);
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
            button4.Location = new Point(215, 216);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(96, 29);
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
            label5.Location = new Point(11, 122);
            label5.Name = "label5";
            label5.Size = new Size(97, 18);
            label5.TabIndex = 34;
            label5.Text = "AmountOrder";
            // 
            // AmountOrder
            // 
            AmountOrder.BorderStyle = BorderStyle.FixedSingle;
            AmountOrder.Location = new Point(11, 156);
            AmountOrder.Margin = new Padding(2);
            AmountOrder.Name = "AmountOrder";
            AmountOrder.Size = new Size(265, 27);
            AmountOrder.TabIndex = 33;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(542, 216);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
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
            label10.Location = new Point(11, 14);
            label10.Name = "label10";
            label10.Size = new Size(92, 18);
            label10.TabIndex = 31;
            label10.Text = "ShippmentID";
            label10.Click += label10_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(373, 14);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 2;
            label3.Text = "ProductID";
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkMagenta;
            button7.Location = new Point(60, 216);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(96, 29);
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
            productid.Location = new Point(373, 46);
            productid.Margin = new Padding(3, 2, 3, 2);
            productid.Name = "productid";
            productid.Size = new Size(265, 26);
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
            label6.Location = new Point(5, 14);
            label6.Name = "label6";
            label6.Size = new Size(0, 18);
            label6.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle5.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle6.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.GridColor = Color.Thistle;
            dataGridView1.Location = new Point(65, 97);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle7.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle7.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle8.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = Color.DarkMagenta;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(866, 213);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(955, 4);
            label2.Name = "label2";
            label2.Size = new Size(30, 29);
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
            label1.Size = new Size(987, 39);
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
            button6.Location = new Point(813, 428);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(118, 46);
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
            button3.Location = new Point(813, 348);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(118, 46);
            button3.TabIndex = 25;
            button3.Text = "DETAILBILLIMPORT";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ShippmentID
            // 
            ShippmentID.BorderStyle = BorderStyle.FixedSingle;
            ShippmentID.Location = new Point(11, 46);
            ShippmentID.Margin = new Padding(2);
            ShippmentID.Name = "ShippmentID";
            ShippmentID.Size = new Size(265, 27);
            ShippmentID.TabIndex = 40;
            // 
            // ADD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1011, 672);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ADD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ADD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}

