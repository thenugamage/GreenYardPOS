namespace testPOS
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CategoryID = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            CategoryDiscription = new DataGridViewTextBoxColumn();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 76);
            label1.Name = "label1";
            label1.Size = new Size(186, 51);
            label1.TabIndex = 13;
            label1.Text = "Category";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CategoryID, CategoryName, CategoryDiscription });
            dataGridView1.Location = new Point(33, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1485, 83);
            dataGridView1.TabIndex = 25;
            // 
            // CategoryID
            // 
            CategoryID.HeaderText = "CategoryID";
            CategoryID.MinimumWidth = 10;
            CategoryID.Name = "CategoryID";
            // 
            // CategoryName
            // 
            CategoryName.HeaderText = "CategoryName";
            CategoryName.MinimumWidth = 10;
            CategoryName.Name = "CategoryName";
            // 
            // CategoryDiscription
            // 
            CategoryDiscription.HeaderText = "CategoryDiscription";
            CategoryDiscription.MinimumWidth = 10;
            CategoryDiscription.Name = "CategoryDiscription";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(592, 816);
            label2.Name = "label2";
            label2.Size = new Size(261, 37);
            label2.TabIndex = 58;
            label2.Text = "Add New Category";
            label2.Click += label2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(571, 799);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 832);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1465, 832);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1524, 898);
            panel1.TabIndex = 61;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Categories";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn CategoryDiscription;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
