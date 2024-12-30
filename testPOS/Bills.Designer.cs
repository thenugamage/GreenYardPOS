namespace testPOS
{
    partial class Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            BillID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            CashierID = new DataGridViewTextBoxColumn();
            SaleDate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            DiscountAmount = new DataGridViewTextBoxColumn();
            NetAmount = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            pictureBox5 = new PictureBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(24, 83);
            label8.Name = "label8";
            label8.Size = new Size(96, 51);
            label8.TabIndex = 22;
            label8.Text = "Bills";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 826);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1469, 826);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BillID, CustomerID, CashierID, SaleDate, TotalAmount, DiscountAmount, NetAmount, PaymentMethod });
            dataGridView1.Location = new Point(3, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1519, 83);
            dataGridView1.TabIndex = 23;
            // 
            // BillID
            // 
            BillID.HeaderText = "BillID";
            BillID.MinimumWidth = 10;
            BillID.Name = "BillID";
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 10;
            CustomerID.Name = "CustomerID";
            // 
            // CashierID
            // 
            CashierID.HeaderText = "CashierID";
            CashierID.MinimumWidth = 10;
            CashierID.Name = "CashierID";
            // 
            // SaleDate
            // 
            SaleDate.HeaderText = "SaleDate";
            SaleDate.MinimumWidth = 10;
            SaleDate.Name = "SaleDate";
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "TotalAmount";
            TotalAmount.MinimumWidth = 10;
            TotalAmount.Name = "TotalAmount";
            // 
            // DiscountAmount
            // 
            DiscountAmount.HeaderText = "DiscountAmount";
            DiscountAmount.MinimumWidth = 10;
            DiscountAmount.Name = "DiscountAmount";
            // 
            // NetAmount
            // 
            NetAmount.HeaderText = "NetAmount";
            NetAmount.MinimumWidth = 10;
            NetAmount.Name = "NetAmount";
            // 
            // PaymentMethod
            // 
            PaymentMethod.HeaderText = "PaymentMethod";
            PaymentMethod.MinimumWidth = 10;
            PaymentMethod.Name = "PaymentMethod";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1457, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(947, 17);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Search By ID";
            textBox3.Size = new Size(575, 61);
            textBox3.TabIndex = 35;
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(pictureBox5);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Bills";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BillID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CashierID;
        private DataGridViewTextBoxColumn SaleDate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn DiscountAmount;
        private DataGridViewTextBoxColumn NetAmount;
        private DataGridViewTextBoxColumn PaymentMethod;
        private PictureBox pictureBox5;
        private TextBox textBox3;
    }
}
