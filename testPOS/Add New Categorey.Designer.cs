namespace testPOS
{
    partial class Add_New_Categorey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Categorey));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 95);
            label1.Name = "label1";
            label1.Size = new Size(362, 51);
            label1.TabIndex = 66;
            label1.Text = "Add New Category";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(376, 431);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Discription";
            textBox2.Size = new Size(739, 61);
            textBox2.TabIndex = 69;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(376, 221);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Customer Name";
            textBox1.Size = new Size(739, 61);
            textBox1.TabIndex = 68;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(376, 326);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "CategoryID";
            textBox3.Size = new Size(739, 61);
            textBox3.TabIndex = 70;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(683, 549);
            label2.Name = "label2";
            label2.Size = new Size(70, 37);
            label2.TabIndex = 72;
            label2.Text = "Add";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(571, 534);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // Add_New_Categorey
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "Add_New_Categorey";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label2;
        private PictureBox pictureBox3;
    }
}
