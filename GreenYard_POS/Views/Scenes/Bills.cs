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
using GreenYard_POS.Views.Stages;

namespace GreenYard_POS.Views.Scenes
{
    public partial class Bills : Form
    {
        private int? selectedCustomerId = null;
        private decimal totalAmount = 0;

        public Bills()
        {
            InitializeComponent();
        }

        private void BillingPage_Load(object sender, EventArgs e)
        {
            LoadAllCustomers();
            LoadAllProducts();
            LoadDiscounts();
            InitializeDataGridView();
            CustomDataGridView(dgvItems);

            selectedCustomerId = null;
            totalAmount = 0;
        }


        private void InitializeDataGridView()
        {
            dgvItems.Columns.Clear();

            DataGridViewTextBoxColumn productIdColumn = new DataGridViewTextBoxColumn();
            productIdColumn.Name = "ProductID";
            productIdColumn.Visible = false;
            dgvItems.Columns.Add(productIdColumn);

            dgvItems.Columns.Add("Number", "Number");
            dgvItems.Columns.Add("ProductName", "Product Name");
            dgvItems.Columns.Add("Quantity", "Quantity");
            dgvItems.Columns.Add("UnitPrice", "Unit Price");
            dgvItems.Columns.Add("Amount", "Amount");

            dgvItems.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
            dgvItems.Columns["Amount"].DefaultCellStyle.Format = "C2";

            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.RowTemplate.Height = 30;
        }

        private void LoadAllProducts()
        {
            try
            {
                BillService billService = new BillService();
                DataTable products = billService.GetAllProducts();

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

        private void LoadAllCustomers()
        {
            try
            {
                BillService billService = new BillService();
                DataTable customers = billService.GetCustomerDetails();

                cmbCustomer.DataSource = null;
                cmbCustomer.DataSource = customers;
                cmbCustomer.DisplayMember = "FullName"; 
                cmbCustomer.ValueMember = "ID"; 
                cmbCustomer.SelectedIndex = -1;

                cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDiscounts()
        {
            try
            {

                BillService billService = new BillService();
                DataTable discounts = billService.GetAllDiscounts();

                cmbDiscount.DataSource = null;
                cmbDiscount.DataSource = discounts;
                cmbDiscount.DisplayMember = "DiscountName";
                cmbDiscount.ValueMember = "DiscountID";
                cmbDiscount.SelectedIndex = -1; 

                cmbDiscount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbDiscount.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading discounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            selectedCustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            
            cmbCustomer.Enabled = false;

            Console.WriteLine($"Customer selected successfully! Customer ID: {selectedCustomerId}");

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            LoadAllCustomers();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.Enabled = true;
            selectedCustomerId = null;

            cmbProduct.SelectedIndex = -1;
            nudQty.Value = 1;

            dgvItems.Rows.Clear();
            totalAmount = 0;
            UpdateTotalAmount();
            cmbDiscount.SelectedIndex = -1;
            lblDiscount.Text = "0";
            lblNetAmount.Text = "0";

            MessageBox.Show("All Data has been reset.", "Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nudQty.Value <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = Convert.ToInt32(cmbProduct.SelectedValue);
                string productName = cmbProduct.Text;
                int quantity = (int)nudQty.Value;

                BillService billService = new BillService();
                decimal unitPrice = billService.GetProductUnitPrice(productId);

                if (unitPrice <= 0)
                {
                    MessageBox.Show("Invalid product price. Please check the product data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal amount = unitPrice * quantity;

                int rowNumber = dgvItems.Rows.Count + 1;
                dgvItems.Rows.Add(productId, rowNumber, productName, quantity, unitPrice.ToString("F2"), amount.ToString("F2"));

                cmbProduct.SelectedIndex = -1;
                nudQty.Value = 1;
                UpdateTotalAmount();
                CalculateNetAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CustomDataGridView(DataGridView dgv)
        {
            // Set all cells' background and foreground colors
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(56, 114, 118);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);

            // Alternating rows (same style to avoid alternation effect)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 114, 118);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Regular);

            // Remove vertical lines, only horizontal lines should appear
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Header styles - using the same color as cells, and update font & height
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 114, 118);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35; // Set header height to be the same as row height

            dgv.EnableHeadersVisualStyles = false;

            // Row height adjustment
            dgv.RowTemplate.Height = 30;

            // Disable selection styling, set selection color to match row color
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 114, 118); // Same as row background
            dgv.DefaultCellStyle.SelectionForeColor = Color.White; // Same as row text color

            // Auto size columns to fit content
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Center-align headers
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Optional: Center-align data
            // dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < dgvItems.Rows.Count; i++)
            {
                dgvItems.Rows[i].Cells["Number"].Value = i + 1;
            }
        }

        private void UpdateTotalAmount()
        {
            try
            {
                totalAmount = 0;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells["Amount"].Value != null)
                    {
                        totalAmount += Convert.ToDecimal(row.Cells["Amount"].Value);
                    }
                }

                lblTotAmount.Text = $"{totalAmount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNumber.Text.Trim(), out int rowNumber))
                {
                   
                    int rowIndex = rowNumber - 1;

                    if (rowIndex >= 0 && rowIndex < dgvItems.Rows.Count)
                    {
                        dgvItems.Rows.RemoveAt(rowIndex);

                        UpdateRowNumbers();
                        txtNumber.Clear();
                        UpdateTotalAmount();
                        //MessageBox.Show($"Row {rowNumber} removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid row number. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid row number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["Amount"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["Amount"].Value);
                }
            }

            return totalAmount;
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscount.SelectedIndex != -1)  
            {

                DataRowView selectedRow = (DataRowView)cmbDiscount.SelectedItem;

                int discountID = Convert.ToInt32(selectedRow["DiscountID"]);

                DiscountService discountService = new DiscountService();
                decimal discountAmount = discountService.GetDiscountAmountById(discountID);

                lblDiscount.Text = $"{discountAmount}"; 
                CalculateNetAmount();

            }
            else
            {

                lblDiscount.Text = "0";
                CalculateNetAmount();
            }
        }

        private void CalculateNetAmount()
        {
            try
            {
                decimal totalAmount = Convert.ToDecimal(lblTotAmount.Text);

                decimal discountAmount = Convert.ToDecimal(lblDiscount.Text);

                decimal netAmount = totalAmount - discountAmount;

                lblNetAmount.Text = $"{netAmount}"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating net amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIssueBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == null)
                {
                    MessageBox.Show("Please select a customer before issuing the bill.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvItems.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one product to the bill.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<BillProduct> products = new List<BillProduct>();
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells["ProductID"].Value != null)
                    {
                        int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        products.Add(new BillProduct(productId, quantity));
                    }
                }

                int? discountId = null;
                if (cmbDiscount.SelectedIndex != -1)
                {
                    discountId = Convert.ToInt32(cmbDiscount.SelectedValue);
                }

                decimal totalAmount = Convert.ToDecimal(lblTotAmount.Text);
                decimal netAmount = Convert.ToDecimal(lblNetAmount.Text);

                BillService billService = new BillService();
                int billId = billService.AddBill(
                    selectedCustomerId.Value,
                    Auth.RoleID,
                    totalAmount,
                    netAmount,
                    discountId,
                    products
                );

                if (billId > 0)
                {
                    MessageBox.Show($"Bill #{billId} has been successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnReset_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to create the bill. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error issuing bill: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
