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
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            LoadAllStocks();
        }

        private void LoadAllStocks()
        {
            try
            {
                StockService StockService = new StockService();
                DataTable allStocks = StockService.GetStockDetails();

                if (allStocks.Rows.Count > 0)
                {
                    dgvStocks.DataSource = allStocks;
                    CustomDataGridView(dgvStocks);

                }
                else
                {
                    MessageBox.Show("No Stocks data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Stocks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.ShowDialog();
            LoadAllStocks();
        }

        private void btnDeleteStocks_Click(object sender, EventArgs e)
        {
            int StockId;

            if (int.TryParse(txtID.Text, out StockId))
            {
                // confirmation
                DialogResult confirmation = MessageBox.Show(
                    $"Are you sure you want to delete Stock with ID {StockId}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        StockService stockService = new StockService();
                        bool isDeleted = stockService.DeleteStock(StockId);

                        if (isDeleted)
                        {
                            MessageBox.Show("Stock deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the Stock. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtID.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the Stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadAllStocks();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            StockService stockService = new StockService();

            DataTable filteredData = stockService.SearchStock(searchTerm);
            dgvStocks.DataSource = filteredData;
     
        }
    }
}
