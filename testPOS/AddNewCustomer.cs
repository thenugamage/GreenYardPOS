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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //navigate to Customer.cs user control
            Panel mainPanel = this.Parent as Panel;
            if (mainPanel != null)
            {
                mainPanel.Controls.Clear();
                Customer customer = new Customer();
                mainPanel.Controls.Add(customer);
                customer.Dock = DockStyle.Fill;
            }

        }
    }
}
