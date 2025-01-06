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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSuppliers_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            SupplierService supplierService = new SupplierService();
            DataTable categories = supplierService.GetCategories();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;

            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContact.Clear();
            txtSupplierName.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text.Trim();
            string contact = txtContact.Text.Trim();
            int categoryId;

            // Validate input fields
            if (string.IsNullOrEmpty(supplierName) ||
                cmbCategory.SelectedValue == null ||
                !int.TryParse(cmbCategory.SelectedValue.ToString(), out categoryId))
            {
                MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SupplierService supplierService = new SupplierService();
                bool isAdded = supplierService.AddSupplier(supplierName, contact, categoryId);

                if (isAdded)
                {
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to add the supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
