namespace testPOS
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            dataGridView1 = new DataGridView();
            salelD = new DataGridViewTextBoxColumn();
            billID = new DataGridViewTextBoxColumn();
            saleDate = new DataGridViewTextBoxColumn();
            totalAmount = new DataGridViewTextBoxColumn();
            discountApplied = new DataGridViewTextBoxColumn();
            finalAmount = new DataGridViewTextBoxColumn();
            paymentMethod = new DataGridViewTextBoxColumn();
            cashierlD = new DataGridViewTextBoxColumn();
            customerID = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { salelD, billID, saleDate, totalAmount, discountApplied, finalAmount, paymentMethod, cashierlD, customerID });
            dataGridView1.Location = new Point(18, 101);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(921, 58);
            dataGridView1.TabIndex = 53;
            // 
            // salelD
            // 
            salelD.HeaderText = "salelD";
            salelD.MinimumWidth = 10;
            salelD.Name = "salelD";
            // 
            // billID
            // 
            billID.HeaderText = "billID";
            billID.MinimumWidth = 10;
            billID.Name = "billID";
            // 
            // saleDate
            // 
            saleDate.HeaderText = "saleDate";
            saleDate.MinimumWidth = 10;
            saleDate.Name = "saleDate";
            // 
            // totalAmount
            // 
            totalAmount.HeaderText = "totalAmount";
            totalAmount.MinimumWidth = 10;
            totalAmount.Name = "totalAmount";
            // 
            // discountApplied
            // 
            discountApplied.HeaderText = "discountApplied";
            discountApplied.MinimumWidth = 10;
            discountApplied.Name = "discountApplied";
            // 
            // finalAmount
            // 
            finalAmount.HeaderText = "finalAmount";
            finalAmount.MinimumWidth = 10;
            finalAmount.Name = "finalAmount";
            // 
            // paymentMethod
            // 
            paymentMethod.HeaderText = "paymentMethod";
            paymentMethod.MinimumWidth = 10;
            paymentMethod.Name = "paymentMethod";
            // 
            // cashierlD
            // 
            cashierlD.HeaderText = "cashierlD";
            cashierlD.MinimumWidth = 10;
            cashierlD.Name = "cashierlD";
            // 
            // customerID
            // 
            customerID.HeaderText = "customerID";
            customerID.MinimumWidth = 10;
            customerID.Name = "customerID";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(584, 18);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By  ID";
            textBox1.Size = new Size(355, 40);
            textBox1.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 41);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 32);
            label8.TabIndex = 51;
            label8.Text = "Sales";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(900, 24);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(pictureBox5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Margin = new Padding(2);
            Name = "Sales";
            Size = new Size(946, 571);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label8;
        private DataGridViewTextBoxColumn salelD;
        private DataGridViewTextBoxColumn billID;
        private DataGridViewTextBoxColumn saleDate;
        private DataGridViewTextBoxColumn totalAmount;
        private DataGridViewTextBoxColumn discountApplied;
        private DataGridViewTextBoxColumn finalAmount;
        private DataGridViewTextBoxColumn paymentMethod;
        private DataGridViewTextBoxColumn cashierlD;
        private DataGridViewTextBoxColumn customerID;
        private PictureBox pictureBox5;
    }
}
