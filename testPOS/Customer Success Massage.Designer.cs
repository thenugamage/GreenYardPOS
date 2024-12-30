namespace testPOS
{
    partial class Customer_Success_Massage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Success_Massage));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(56, 11);
            label1.Name = "label1";
            label1.Size = new Size(67, 32);
            label1.TabIndex = 3;
            label1.Text = "Back";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 116, 120);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(556, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 613);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(57, 116, 120);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(104, 244);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(540, 85);
            textBox2.TabIndex = 1;
            textBox2.Text = "Added Successfully!";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(57, 116, 120);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(35, 335);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(676, 92);
            textBox1.TabIndex = 0;
            textBox1.Text = "Customer has been successfully added! \r\nSearch for the customer using their contact number.\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Customer_Success_Massage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 54, 66);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1881, 1008);
            Controls.Add(panel1);
            Name = "Customer_Success_Massage";
            Text = "Customer_Success_Massage";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}