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
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            reportID = new DataGridViewTextBoxColumn();
            reportDate = new DataGridViewTextBoxColumn();
            totalSalesAmount = new DataGridViewTextBoxColumn();
            totalDiscountAmount = new DataGridViewTextBoxColumn();
            numberOfSales = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(584, 18);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Contact Number";
            textBox1.Size = new Size(355, 40);
            textBox1.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(7, 74);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 32);
            label8.TabIndex = 40;
            label8.Text = "Sales Report";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(898, 18);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 36);
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
            dataGridView1.Location = new Point(29, 136);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(664, 48);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SalesReport";
            Size = new Size(946, 571);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label8;
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
