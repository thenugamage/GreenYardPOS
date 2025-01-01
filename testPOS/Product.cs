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
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Assuming you have a panel or some container to hold the UserControl
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                AddNewProduct addNewProduct = new AddNewProduct();
                addNewProduct.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(addNewProduct);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Assuming you have a panel or some container to hold the UserControl
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                Customer customerControl = new Customer();
                customerControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(customerControl);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Navigate to Categories UserControl
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                Categories categoriesControl = new Categories();
                categoriesControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(categoriesControl);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
    }
}
