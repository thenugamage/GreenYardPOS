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
            label8 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerFirstName, CustomerLastName, CustomerContactNum, CustomerNIC });
            dataGridView1.Location = new Point(48, 80);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(852, 51);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(16, 25);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 19;
            label8.Text = "Customers";
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(36, 54, 66);
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(751, 476);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 65;
            label3.Text = "Remove Customer";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(733, 466);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(189, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(36, 54, 66);
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 476);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(167, 23);
            label4.TabIndex = 63;
            label4.Text = "Add New Customer";
            label4.Click += label4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(26, 466);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(189, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 62;
            pictureBox5.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(348, 513);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Customer ID";
            textBox2.Size = new Size(355, 40);
            textBox2.TabIndex = 61;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(348, 459);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Customer Name";
            textBox1.Size = new Size(355, 40);
            textBox1.TabIndex = 60;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(238, 521);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 59;
            label5.Text = "Customer ID";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(224, 467);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 58;
            label6.Text = "Customer Name";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Margin = new Padding(2);
            Name = "Customer";
            Size = new Size(946, 571);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label label8;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
    }
}
