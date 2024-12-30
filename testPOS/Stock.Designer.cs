namespace testPOS
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            stockID = new DataGridViewTextBoxColumn();
            productID = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            minimumStockLevel = new DataGridViewTextBoxColumn();
            lastRestockDate = new DataGridViewTextBoxColumn();
            supplierID = new DataGridViewTextBoxColumn();
            lastUpdated = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1461, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(949, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By  ID";
            textBox1.Size = new Size(575, 61);
            textBox1.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 119);
            label8.Name = "label8";
            label8.Size = new Size(119, 51);
            label8.TabIndex = 45;
            label8.Text = "Stock";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 830);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
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
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stockID, productID, quantity, minimumStockLevel, lastRestockDate, supplierID, lastUpdated });
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1488, 77);
            dataGridView1.TabIndex = 48;
            // 
            // stockID
            // 
            stockID.HeaderText = "stockID";
            stockID.MinimumWidth = 10;
            stockID.Name = "stockID";
            // 
            // productID
            // 
            productID.HeaderText = "productID";
            productID.MinimumWidth = 10;
            productID.Name = "productID";
            // 
            // quantity
            // 
            quantity.HeaderText = "quantity";
            quantity.MinimumWidth = 10;
            quantity.Name = "quantity";
            // 
            // minimumStockLevel
            // 
            minimumStockLevel.HeaderText = "minimumStockLevel";
            minimumStockLevel.MinimumWidth = 10;
            minimumStockLevel.Name = "minimumStockLevel";
            // 
            // lastRestockDate
            // 
            lastRestockDate.HeaderText = "lastRestockDate";
            lastRestockDate.MinimumWidth = 10;
            lastRestockDate.Name = "lastRestockDate";
            // 
            // supplierID
            // 
            supplierID.HeaderText = "supplierID";
            supplierID.MinimumWidth = 10;
            supplierID.Name = "supplierID";
            // 
            // lastUpdated
            // 
            lastUpdated.HeaderText = "lastUpdated";
            lastUpdated.MinimumWidth = 10;
            lastUpdated.Name = "lastUpdated";
            // 
            // Stock
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
            Name = "Stock";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TextBox textBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stockID;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn minimumStockLevel;
        private DataGridViewTextBoxColumn lastRestockDate;
        private DataGridViewTextBoxColumn supplierID;
        private DataGridViewTextBoxColumn lastUpdated;
    }
}
