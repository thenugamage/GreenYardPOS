namespace testPOS
{
    partial class AddNewDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDiscount));
            label8 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 48);
            label8.Name = "label8";
            label8.Size = new Size(356, 51);
            label8.TabIndex = 48;
            label8.Text = "Add New Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(774, 665);
            label2.Name = "label2";
            label2.Size = new Size(70, 37);
            label2.TabIndex = 61;
            label2.Text = "Add";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(656, 650);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(91, 290);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Discount Type";
            textBox3.Size = new Size(739, 61);
            textBox3.TabIndex = 59;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(91, 395);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Discount Value";
            textBox2.Size = new Size(739, 61);
            textBox2.TabIndex = 58;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(91, 185);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Discount Id";
            textBox1.Size = new Size(739, 61);
            textBox1.TabIndex = 57;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top;
            monthCalendar1.Location = new Point(1036, 185);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 62;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(91, 489);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Start Date";
            textBox4.Size = new Size(340, 61);
            textBox4.TabIndex = 63;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(491, 489);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "End Date";
            textBox5.Size = new Size(339, 61);
            textBox5.TabIndex = 64;
            // 
            // AddNewDiscount
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Name = "AddNewDiscount";
            Size = new Size(1537, 913);
            Load += AddNewDiscount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        // Add the missing event handler method for label2_Click
        private void label2_Click(object sender, EventArgs e)
        {
            // Add your event handling code here
        }

        #endregion

        private Label label8;
        private Label label2;
        private PictureBox pictureBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
