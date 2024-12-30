namespace testPOS
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox5 = new PictureBox();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            CategoryID = new DataGridViewTextBoxColumn();
            QuantitylnStock = new DataGridViewTextBoxColumn();
            SupplierID = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            DiscountID = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 755);
            label2.Name = "label2";
            label2.Size = new Size(244, 37);
            label2.TabIndex = 26;
            label2.Text = "Add New Product";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(50, 740);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 31);
            label8.Name = "label8";
            label8.Size = new Size(180, 51);
            label8.TabIndex = 24;
            label8.Text = "Products";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 826);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
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
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(36, 54, 66);
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1216, 755);
            label1.Name = "label1";
            label1.Size = new Size(230, 37);
            label1.TabIndex = 28;
            label1.Text = "Remove Product";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1177, 740);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(307, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(394, 740);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 29;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(394, 826);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 30;
            label4.Text = "Product ID";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(572, 727);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Product Name";
            textBox1.Size = new Size(575, 61);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(572, 813);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Product ID";
            textBox2.Size = new Size(575, 61);
            textBox2.TabIndex = 32;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(947, 21);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Search By ID";
            textBox3.Size = new Size(575, 61);
            textBox3.TabIndex = 33;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1457, 24);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, UnitPrice, CategoryID, QuantitylnStock, SupplierID, Barcode, DiscountID, IsActive });
            dataGridView1.Location = new Point(15, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1505, 82);
            dataGridView1.TabIndex = 35;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.MinimumWidth = 10;
            ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.MinimumWidth = 10;
            ProductName.Name = "ProductName";
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 10;
            UnitPrice.Name = "UnitPrice";
            // 
            // CategoryID
            // 
            CategoryID.HeaderText = "CategoryID";
            CategoryID.MinimumWidth = 10;
            CategoryID.Name = "CategoryID";
            // 
            // QuantitylnStock
            // 
            QuantitylnStock.HeaderText = "QuantitylnStock";
            QuantitylnStock.MinimumWidth = 10;
            QuantitylnStock.Name = "QuantitylnStock";
            // 
            // SupplierID
            // 
            SupplierID.HeaderText = "SupplierID";
            SupplierID.MinimumWidth = 10;
            SupplierID.Name = "SupplierID";
            // 
            // Barcode
            // 
            Barcode.HeaderText = "Barcode";
            Barcode.MinimumWidth = 10;
            Barcode.Name = "Barcode";
            // 
            // DiscountID
            // 
            DiscountID.HeaderText = "DiscountID";
            DiscountID.MinimumWidth = 10;
            DiscountID.Name = "DiscountID";
            // 
            // IsActive
            // 
            IsActive.HeaderText = "IsActive";
            IsActive.MinimumWidth = 10;
            IsActive.Name = "IsActive";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Product";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox3;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn QuantitylnStock;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn DiscountID;
        private DataGridViewTextBoxColumn IsActive;
    }
}
