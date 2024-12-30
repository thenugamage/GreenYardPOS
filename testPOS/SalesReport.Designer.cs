namespace testPOS
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            textBox1 = new TextBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            reportID = new DataGridViewTextBoxColumn();
            reportDate = new DataGridViewTextBoxColumn();
            totalSalesAmount = new DataGridViewTextBoxColumn();
            totalDiscountAmount = new DataGridViewTextBoxColumn();
            numberOfSales = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(949, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Contact Number";
            textBox1.Size = new Size(575, 61);
            textBox1.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 119);
            label8.Name = "label8";
            label8.Size = new Size(245, 51);
            label8.TabIndex = 40;
            label8.Text = "Sales Report";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 830);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1471, 830);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1459, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 42;
            pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { reportID, reportDate, totalSalesAmount, totalDiscountAmount, numberOfSales, startDate, endDate });
            dataGridView1.Location = new Point(47, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1079, 77);
            dataGridView1.TabIndex = 43;
            // 
            // reportID
            // 
            reportID.HeaderText = "reportID";
            reportID.MinimumWidth = 10;
            reportID.Name = "reportID";
            // 
            // reportDate
            // 
            reportDate.HeaderText = "reportDate";
            reportDate.MinimumWidth = 10;
            reportDate.Name = "reportDate";
            // 
            // totalSalesAmount
            // 
            totalSalesAmount.HeaderText = "totalSalesAmount";
            totalSalesAmount.MinimumWidth = 10;
            totalSalesAmount.Name = "totalSalesAmount";
            // 
            // totalDiscountAmount
            // 
            totalDiscountAmount.HeaderText = "totalDiscountAmount";
            totalDiscountAmount.MinimumWidth = 10;
            totalDiscountAmount.Name = "totalDiscountAmount";
            // 
            // numberOfSales
            // 
            numberOfSales.HeaderText = "numberOfSales";
            numberOfSales.MinimumWidth = 10;
            numberOfSales.Name = "numberOfSales";
            // 
            // startDate
            // 
            startDate.HeaderText = "startDate";
            startDate.MinimumWidth = 10;
            startDate.Name = "startDate";
            // 
            // endDate
            // 
            endDate.HeaderText = "endDate";
            endDate.MinimumWidth = 10;
            endDate.Name = "endDate";
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "SalesReport";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn reportID;
        private DataGridViewTextBoxColumn reportDate;
        private DataGridViewTextBoxColumn totalSalesAmount;
        private DataGridViewTextBoxColumn totalDiscountAmount;
        private DataGridViewTextBoxColumn numberOfSales;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
    }
}
