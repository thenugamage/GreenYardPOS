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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Assuming you have a panel or some container to hold the user controls
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                // Clear existing controls
                mainPanel.Controls.Clear();

                // Create an instance of AddNewCustomer user control
                AddNewCustomer addNewCustomer = new AddNewCustomer();

                // Add the AddNewCustomer user control to the panel
                mainPanel.Controls.Add(addNewCustomer);

                // Optionally, dock the user control to fill the panel
                addNewCustomer.Dock = DockStyle.Fill;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Assuming you have a panel or some container to hold the user controls
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                // Clear existing controls
                mainPanel.Controls.Clear();

                // Create an instance of AddNewCustomer user control
                AddNewCustomer addNewCustomer = new AddNewCustomer();

                // Add the AddNewCustomer user control to the panel
                mainPanel.Controls.Add(addNewCustomer);

                // Optionally, dock the user control to fill the panel
                addNewCustomer.Dock = DockStyle.Fill;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Assuming you have a panel or some container to hold the user controls
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                // Clear existing controls
                mainPanel.Controls.Clear();

                // Create an instance of Product user control
                Product productControl = new Product();

                // Add the Product user control to the panel
                mainPanel.Controls.Add(productControl);

                // Optionally, dock the user control to fill the panel
                productControl.Dock = DockStyle.Fill;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //navigate to AddNewCustomer.cs user control
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            this.Parent.Controls.Add(addNewCustomer);
            this.Parent.Controls.Remove(this);

        }
    }
}
