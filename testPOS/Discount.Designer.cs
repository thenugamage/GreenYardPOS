namespace testPOS
{
    partial class Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount));
            label8 = new Label();
            dataGridView1 = new DataGridView();
            discountID = new DataGridViewTextBoxColumn();
            discountName = new DataGridViewTextBoxColumn();
            discountType = new DataGridViewTextBoxColumn();
            discountValue = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            productID = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 61);
            label8.Name = "label8";
            label8.Size = new Size(180, 51);
            label8.TabIndex = 20;
            label8.Text = "Discount";
            label8.Click += label8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 116, 120);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { discountID, discountName, discountType, discountValue, startDate, endDate, productID, status });
            dataGridView1.Location = new Point(0, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1534, 86);
            dataGridView1.TabIndex = 23;
            // 
            // discountID
            // 
            discountID.HeaderText = "discountID";
            discountID.MinimumWidth = 10;
            discountID.Name = "discountID";
            // 
            // discountName
            // 
            discountName.HeaderText = "discountName";
            discountName.MinimumWidth = 10;
            discountName.Name = "discountName";
            // 
            // discountType
            // 
            discountType.HeaderText = "discountType";
            discountType.MinimumWidth = 10;
            discountType.Name = "discountType";
            // 
            // discountValue
            // 
            discountValue.HeaderText = "discountValue";
            discountValue.MinimumWidth = 10;
            discountValue.Name = "discountValue";
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
            // productID
            // 
            productID.HeaderText = "productID";
            productID.MinimumWidth = 10;
            productID.Name = "productID";
            // 
            // status
            // 
            status.HeaderText = "status";
            status.MinimumWidth = 10;
            status.Name = "status";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(643, 845);
            label2.Name = "label2";
            label2.Size = new Size(255, 37);
            label2.TabIndex = 27;
            label2.Text = "Add New Discount";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(613, 830);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 845);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1468, 845);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 907);
            panel1.TabIndex = 28;
            // 
            // Discount
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "Discount";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private DataGridView dataGridView1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn discountID;
        private DataGridViewTextBoxColumn discountName;
        private DataGridViewTextBoxColumn discountType;
        private DataGridViewTextBoxColumn discountValue;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn status;
        private Panel panel1;
    }
}
