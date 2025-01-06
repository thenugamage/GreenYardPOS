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
    public partial class SupplierProduct : Form
    {
        public SupplierProduct()
        {
            InitializeComponent();
        }

        private void SupplierProductForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadProducts();
        }

        private void LoadSuppliers()
        {
            SupplierService supplierService = new SupplierService();
            DataTable suppliers = supplierService.GetSuppliers();

            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = "SupplierName";
            cmbSuppliers.ValueMember = "SupplierID";
            cmbSuppliers.SelectedIndex = -1;

            cmbSuppliers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSuppliers.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadProducts()
        {
            SupplierService supplierService = new SupplierService();
            DataTable products = supplierService.GetProducts();

            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "ProductID";
            cmbProducts.SelectedIndex = -1;

            cmbProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducts.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedValue == null || cmbProducts.SelectedValue == null)
            {
                MessageBox.Show("Please select both a supplier and a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierId = Convert.ToInt32(cmbSuppliers.SelectedValue);
            int productId = Convert.ToInt32(cmbProducts.SelectedValue);

            SupplierService supplierService = new SupplierService();
            bool isAdded = supplierService.AddSupplierProduct(supplierId, productId);

            if (isAdded)
            {
                MessageBox.Show("Supplier product association added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, refresh data if needed.
            }
            else
            {
                MessageBox.Show("Failed to add the supplier-product association. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbProducts.SelectedIndex = -1;
            cmbSuppliers.SelectedIndex = -1;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedValue == null || cmbProducts.SelectedValue == null)
            {
                MessageBox.Show("Please select both a supplier and a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int supplierId = Convert.ToInt32(cmbSuppliers.SelectedValue);
            int productId = Convert.ToInt32(cmbProducts.SelectedValue);

            SupplierService supplierService = new SupplierService();
            bool isDeleted = supplierService.DeleteSupplierProduct(supplierId, productId);

            if (isDeleted)
            {
                MessageBox.Show("Supplier product association deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, refresh data if needed.
            }
            else
            {
                MessageBox.Show("Failed to delete the supplier-product association. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
