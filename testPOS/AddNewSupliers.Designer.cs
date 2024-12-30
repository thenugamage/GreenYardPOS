namespace testPOS
{
    partial class AddNewSupliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSupliers));
            label8 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            suppliername = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(89, 52);
            label8.Name = "label8";
            label8.Size = new Size(341, 51);
            label8.TabIndex = 48;
            label8.Text = "Add New Supliers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(733, 539);
            label2.Name = "label2";
            label2.Size = new Size(70, 37);
            label2.TabIndex = 61;
            label2.Text = "Add";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(615, 524);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(399, 328);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Suplier ID";
            textBox3.Size = new Size(739, 61);
            textBox3.TabIndex = 59;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(399, 433);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Suplier Contact Number";
            textBox2.Size = new Size(739, 61);
            textBox2.TabIndex = 58;
            // 
            // suppliername
            // 
            suppliername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            suppliername.Font = new Font("Segoe UI", 12F);
            suppliername.Location = new Point(399, 223);
            suppliername.Multiline = true;
            suppliername.Name = "suppliername";
            suppliername.PlaceholderText = "Suplier Name";
            suppliername.Size = new Size(739, 61);
            suppliername.TabIndex = 57;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // AddNewSupliers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(suppliername);
            Controls.Add(label8);
            Name = "AddNewSupliers";
            Size = new Size(1537, 913);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label2;
        private PictureBox pictureBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox suppliername;
        private PictureBox pictureBox2;
        private TextBox textBox1;
    }
}
