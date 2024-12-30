using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPOS
{
    public partial class AddNewCustomer : UserControl
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AddNewCustomer));
            label2 = new Label();
            pictureBox3 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            ((ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(36, 54, 66);
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(719, 589);
            label2.Name = "label2";
            label2.Size = new Size(70, 37);
            label2.TabIndex = 61;
            label2.Text = "Add";
            label2.Click += label2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(601, 574);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(307, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(385, 378);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Address";
            textBox3.Size = new Size(739, 61);
            textBox3.TabIndex = 59;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(385, 483);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Contact";
            textBox2.Size = new Size(739, 61);
            textBox2.TabIndex = 58;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(385, 273);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Customer Name";
            textBox1.Size = new Size(739, 61);
            textBox1.TabIndex = 57;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 913);
            panel1.TabIndex = 62;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 42);
            label1.Name = "label1";
            label1.Size = new Size(371, 51);
            label1.TabIndex = 64;
            label1.Text = "Add New Customer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(16, 30);
            label8.Name = "label8";
            label8.Size = new Size(371, 51);
            label8.TabIndex = 48;
            label8.Text = "Add New Customer";
            // 
            // AddNewCustomer
            // 
            BackColor = Color.FromArgb(57, 116, 120);
            Controls.Add(panel1);
            Controls.Add(label8);
            Name = "AddNewCustomer";
            Size = new Size(1537, 913);
            ((ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
