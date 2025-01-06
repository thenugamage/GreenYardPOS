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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            ProductService productService = new ProductService();
            DataTable categories = productService.GetCategories();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1; 

            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtUnit.Clear();
            txtDetails.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            string unit = txtUnit.Text.Trim();
            decimal unitPrice;
            string productDetails = txtDetails.Text.Trim();
            int categoryId;

            if (string.IsNullOrEmpty(productName) ||
                !decimal.TryParse(txtUnitPrice.Text.Trim(), out unitPrice) ||
                cmbCategory.SelectedValue == null ||
                !int.TryParse(cmbCategory.SelectedValue.ToString(), out categoryId))
            {
                MessageBox.Show("Please fill all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (unitPrice < 0)
            {
                MessageBox.Show("Unit Price cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ProductService productService = new ProductService();
                bool isAdded = productService.AddProduct(productName, unit, unitPrice, productDetails, categoryId);

                if (isAdded)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e); 
                }
                else
                {
                    MessageBox.Show("Failed to add the product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
