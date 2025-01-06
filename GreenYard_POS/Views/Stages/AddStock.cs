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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadAllSuppliers(); 
        }

        private void LoadAllSuppliers()
        {
            try
            {
                StockService stockService = new StockService();
                DataTable suppliers = stockService.GetAllSuppliers(); 

                cmbSupplier.DataSource = null;
        
                cmbSupplier.DataSource = suppliers;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierID"; 
                cmbSupplier.SelectedIndex = -1;

                cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductsBySupplier(int supplierId)
        {
            try
            {
                StockService stockService = new StockService();
                DataTable products = stockService.GetProductsBySupplierID(supplierId); 
               
                cmbProduct.DataSource = null;

                cmbProduct.DataSource = products;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";
                cmbProduct.SelectedIndex = -1;

                cmbProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedValue != null && int.TryParse(cmbSupplier.SelectedValue.ToString(), out int supplierId))
            {
                LoadProductsBySupplier(supplierId);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            txtQty.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbSupplier.SelectedValue?.ToString(), out int supplierId) || supplierId <= 0)
            {
                MessageBox.Show("Please select a valid supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cmbProduct.SelectedValue?.ToString(), out int productId) || productId <= 0)
            {
                MessageBox.Show("Please select a valid product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StockService stockService = new StockService();
            bool isAdded = stockService.AddStock(supplierId, productId, quantity);

            if (isAdded)
            {
                MessageBox.Show("Stock added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed to add stock. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
