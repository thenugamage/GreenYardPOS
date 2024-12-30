namespace testPOS
{
    partial class Important
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Important));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 116, 120);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(538, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 613);
            panel1.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(504, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(57, 116, 120);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(109, 60);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(540, 105);
            textBox2.TabIndex = 1;
            textBox2.Text = "IMPORTANT";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(57, 116, 120);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(42, 151);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(676, 333);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Important
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1881, 1008);
            Controls.Add(panel1);
            Name = "Important";
            Text = "Important";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}