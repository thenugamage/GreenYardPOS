namespace testPOS.controls
{
    partial class UserControlcostomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlcostomers));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(689, 21);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search By Date";
            textBox1.Size = new Size(392, 39);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1032, 21);
            button1.Name = "button1";
            button1.Size = new Size(49, 39);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1455, 21);
            button2.Name = "button2";
            button2.Size = new Size(49, 39);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1112, 21);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search By Contact Number";
            textBox2.Size = new Size(392, 39);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 62);
            label1.Name = "label1";
            label1.Size = new Size(195, 51);
            label1.TabIndex = 4;
            label1.Text = "Customer";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(36, 54, 66);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(580, 824);
            button3.Name = "button3";
            button3.Size = new Size(383, 61);
            button3.TabIndex = 5;
            button3.Text = "ADD CUSTOMER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1451, 830);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 830);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1285, 641);
            dataGridView1.TabIndex = 8;
            // 
            // UserControlcostomers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            ForeColor = Color.Cyan;
            Name = "UserControlcostomers";
            Size = new Size(1537, 913);
            Load += UserControlcostomers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}
