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
    public partial class AddDiscount : Form
    {
        public AddDiscount()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input fields
                string discountName = txtName.Text.Trim();
                decimal discountAmount;
                if (!decimal.TryParse(txtAmount.Text.Trim(), out discountAmount))
                {
                    MessageBox.Show("Please enter a valid discount amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime startDate = StartDate.Value;
                DateTime endDate = EndDate.Value;

                // Validation checks
                if (string.IsNullOrEmpty(discountName))
                {
                    MessageBox.Show("Please enter a discount name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (discountAmount <= 0)
                {
                    MessageBox.Show("Discount amount must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (startDate > endDate)
                {
                    MessageBox.Show("End date must be greater than the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the discount service object and call the method to save
                DiscountService discountService = new DiscountService();
                bool isAdded = discountService.AddDiscount(discountName, discountAmount, startDate, endDate);

                if (isAdded)
                {
                    MessageBox.Show("Discount added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender,e); // Clear the fields after saving
                }
                else
                {
                    MessageBox.Show("Failed to add the discount. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving discount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAmount.Clear();
            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
        }
    }
}
