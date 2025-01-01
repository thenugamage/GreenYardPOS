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
            dataGridView1 = new DataGridView();
            stockID = new DataGridViewTextBoxColumn();
            productID = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            minimumStockLevel = new DataGridViewTextBoxColumn();
            lastRestockDate = new DataGridViewTextBoxColumn();
            supplierID = new DataGridViewTextBoxColumn();
            lastUpdated = new DataGridViewTextBoxColumn();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(899, 19);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
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
            textBox1.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(7, 74);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 32);
            label8.TabIndex = 45;
            label8.Text = "Stock";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { stockID, productID, quantity, minimumStockLevel, lastRestockDate, supplierID, lastUpdated });
            dataGridView1.Location = new Point(7, 116);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(916, 60);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(402, 477);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 23);
            label2.TabIndex = 50;
            label2.Text = "Add New Stock";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(376, 467);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox4);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Margin = new Padding(2);
            Name = "Stock";
            Size = new Size(946, 571);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TextBox textBox1;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn stockID;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn minimumStockLevel;
        private DataGridViewTextBoxColumn lastRestockDate;
        private DataGridViewTextBoxColumn supplierID;
        private DataGridViewTextBoxColumn lastUpdated;
        private Label label2;
        private PictureBox pictureBox3;
    }
}
