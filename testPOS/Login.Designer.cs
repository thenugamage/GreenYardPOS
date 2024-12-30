namespace testPOS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(301, 20);
            label1.Name = "label1";
            label1.Size = new Size(172, 72);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Blue;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.Lavender;
            linkLabel1.Location = new Point(480, 295);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(214, 37);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(62, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Email";
            textBox1.Size = new Size(632, 60);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(62, 231);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(632, 60);
            textBox2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(227, 405);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(337, 417);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 10;
            label2.Text = "Login";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(57, 116, 120);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.MediumSeaGreen;
            panel1.Location = new Point(548, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 539);
            panel1.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1881, 1008);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
    }
}