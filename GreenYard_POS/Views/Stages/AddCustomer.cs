using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenYard_POS.Services;

namespace GreenYard_POS.Views.Stages
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtContactNo.Clear();
            txtNIC.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text.Trim();
            string lastName = txtLname.Text.Trim();
            string contactNum = txtContactNo.Text.Trim();
            string nic = txtNIC.Text.Trim();

            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(contactNum) || string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("Fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (contactNum.Length <10)
            {
                MessageBox.Show("Please enter a valid Contact.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nic.Length < 10)
            {
                MessageBox.Show("Please enter a valid NIC.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CustomerService customerService = new CustomerService();
                bool isAdded = customerService.AddCustomer(firstName, lastName, contactNum, nic);

                if (isAdded)
                {
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to add the customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
