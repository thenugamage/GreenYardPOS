namespace testPOS
{
    partial class Suplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suplier));
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            supplierID = new DataGridViewTextBoxColumn();
            supplierName = new DataGridViewTextBoxColumn();
            supplierContactNum = new DataGridViewTextBoxColumn();
            productID = new DataGridViewTextBoxColumn();
            categoryID = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 53);
            label1.Name = "label1";
            label1.Size = new Size(148, 51);
            label1.TabIndex = 12;
            label1.Text = "Suplier";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(638, 826);
            label2.Name = "label2";
            label2.Size = new Size(244, 37);
            label2.TabIndex = 20;
            label2.Text = "Add New Supliers";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(614, 811);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 826);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
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
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { supplierID, supplierName, supplierContactNum, productID, categoryID });
            dataGridView1.Location = new Point(14, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1508, 84);
            dataGridView1.TabIndex = 21;
            // 
            // supplierID
            // 
            supplierID.HeaderText = "supplierID";
            supplierID.MinimumWidth = 10;
            supplierID.Name = "supplierID";
            // 
            // supplierName
            // 
            supplierName.HeaderText = "supplierName";
            supplierName.MinimumWidth = 10;
            supplierName.Name = "supplierName";
            // 
            // supplierContactNum
            // 
            supplierContactNum.HeaderText = "supplierContactNum";
            supplierContactNum.MinimumWidth = 10;
            supplierContactNum.Name = "supplierContactNum";
            // 
            // productID
            // 
            productID.HeaderText = "productID";
            productID.MinimumWidth = 10;
            productID.Name = "productID";
            // 
            // categoryID
            // 
            categoryID.HeaderText = "categoryID";
            categoryID.MinimumWidth = 10;
            categoryID.Name = "categoryID";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1533, 911);
            panel1.TabIndex = 22;
            // 
            // Suplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Suplier";
            Size = new Size(1537, 913);
            Load += Suplier_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn supplierID;
        private DataGridViewTextBoxColumn supplierName;
        private DataGridViewTextBoxColumn supplierContactNum;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn categoryID;
        private Panel panel1;
    }
}
