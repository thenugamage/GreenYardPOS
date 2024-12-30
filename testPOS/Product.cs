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
    }
}
