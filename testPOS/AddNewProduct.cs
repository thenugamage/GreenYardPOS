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
    public partial class AddNewProduct : UserControl
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //navigate to Product.cs UserControl
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                Product productControl = new Product();
                productControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(productControl);
            }
        }
    }
}
