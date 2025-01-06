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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadAllSuppliers();
        }

        private void LoadAllSuppliers()
        {
            try
            {
                SupplierService supplierService = new SupplierService();
                DataTable allSupplier = supplierService.GetAllSuppliers();

                if (allSupplier.Rows.Count > 0)
                {
                    dgvSuppliers.DataSource = allSupplier;
                    CustomDataGridView(dgvSuppliers);

                }
                else
                {
                    MessageBox.Show("No Supplier data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.ShowDialog();
            LoadAllSuppliers();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int SupplierId;

            if (int.TryParse(txtID.Text, out SupplierId))
            {
                // confirmation
                DialogResult confirmation = MessageBox.Show(
                    $"Are you sure you want to delete Supplier with ID {SupplierId}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        SupplierService supplierService = new SupplierService();
                        bool isDeleted = supplierService.DeleteSupplier(SupplierId);

                        if (isDeleted)
                        {
                            MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the Supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtID.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the Supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtID.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAllSuppliers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            SupplierService supplierService = new SupplierService();

            DataTable filteredData = supplierService.SearchSuppliers(searchTerm);

            dgvSuppliers.DataSource = filteredData;
        }

        private void btnSupProduct_Click(object sender, EventArgs e)
        {
            SupplierProduct supplierProduct = new SupplierProduct();
            supplierProduct.ShowDialog();
            LoadAllSuppliers();
        }
    }
}
