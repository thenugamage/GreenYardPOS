namespace testPOS
{
    partial class Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            dataGridView1 = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerFirstName = new DataGridViewTextBoxColumn();
            CustomerLastName = new DataGridViewTextBoxColumn();
            CustomerContactNum = new DataGridViewTextBoxColumn();
            CustomerNIC = new DataGridViewTextBoxColumn();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerFirstName, CustomerLastName, CustomerContactNum, CustomerNIC });
            dataGridView1.Location = new Point(56, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1385, 82);
            dataGridView1.TabIndex = 22;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 10;
            CustomerID.Name = "CustomerID";
            // 
            // CustomerFirstName
            // 
            CustomerFirstName.HeaderText = "CategoryName";
            CustomerFirstName.MinimumWidth = 10;
            CustomerFirstName.Name = "CustomerFirstName";
            // 
            // CustomerLastName
            // 
            CustomerLastName.HeaderText = "CustomerLastName";
            CustomerLastName.MinimumWidth = 10;
            CustomerLastName.Name = "CustomerLastName";
            // 
            // CustomerContactNum
            // 
            CustomerContactNum.HeaderText = "CustomerContactNum";
            CustomerContactNum.MinimumWidth = 10;
            CustomerContactNum.Name = "CustomerContactNum";
            // 
            // CustomerNIC
            // 
            CustomerNIC.HeaderText = "CustomerNIC";
            CustomerNIC.MinimumWidth = 10;
            CustomerNIC.Name = "CustomerNIC";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(662, 826);
            label2.Name = "label2";
            label2.Size = new Size(201, 37);
            label2.TabIndex = 21;
            label2.Text = "Add Customer";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(607, 811);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 115);
            label8.Name = "label8";
            label8.Size = new Size(212, 51);
            label8.TabIndex = 19;
            label8.Text = "Customers";
            label8.Click += label8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 826);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1462, 826);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(868, 38);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(339, 24);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Search By Date";
            textBox3.Size = new Size(575, 61);
            textBox3.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(940, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Contact Number";
            textBox1.Size = new Size(575, 61);
            textBox1.TabIndex = 37;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1465, 36);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(pictureBox5);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Customer";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerFirstName;
        private DataGridViewTextBoxColumn CustomerLastName;
        private DataGridViewTextBoxColumn CustomerContactNum;
        private DataGridViewTextBoxColumn CustomerNIC;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private TextBox textBox3;
        private TextBox textBox1;
        private PictureBox pictureBox4;
    }
}
