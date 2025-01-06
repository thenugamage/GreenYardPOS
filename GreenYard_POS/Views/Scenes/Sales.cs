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

namespace GreenYard_POS.Views.Scenes
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadAllSales();
            cmbDateRange.SelectedIndex = 0;
            RefreshData();
        }

        private void LoadAllSales()
        {
            try
            {
                SalesService sales = new SalesService();
                DataTable allSales = sales.GetAllSales();

                if (allSales.Rows.Count > 0)
                {
                    dgvSales.DataSource = allSales;
                    CustomDataGridView(dgvSales);

                }
                else
                {
                    MessageBox.Show("No customer data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CmbDateRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool showCustomRange = cmbDateRange.SelectedItem.ToString() == "Custom Range";
            dtpStartDate.Visible = showCustomRange;
            dtpEndDate.Visible = showCustomRange;
            lblStartDate.Visible = showCustomRange;
            lblEndDate.Visible = showCustomRange;

            if (!showCustomRange)
            {
                UpdateDateRange();
                RefreshData();
            }
        }

        private void RefreshData()
        {
            try
            {

                //var salesData = _salesService.SearchSales(txtSearch.Text.Trim());
                //dgvSales.DataSource = salesData;

                SalesService _salesService = new SalesService();

                DataTable filteredData = _salesService.GetSalesByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                dgvSales.DataSource = filteredData;

                var summaryData = _salesService.GetSalesSummary(dtpStartDate.Value, dtpEndDate.Value);
                if (summaryData.Rows.Count > 0)
                {
                    var row = summaryData.Rows[0];
                    lblTotalAmount.Text = $"Total Amount: {row["Total Amount"]:C2}";
                    lblDiscountAmount.Text = $"Total Discount: {row["Total Discount"]:C2}";
                    lblNetAmount.Text = $"Net Amount: {row["Total Net Amount"]:C2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDateRange()
        {
            switch (cmbDateRange.SelectedItem.ToString())
            {
                case "All":
                    dtpStartDate.Value = new DateTime(2000, 1, 1);
                    dtpEndDate.Value = new DateTime(2030, 1, 1);
                    break;
                case "Today":
                    dtpStartDate.Value = DateTime.Today;
                    dtpEndDate.Value = DateTime.Today;
                    break;
                case "This Week":
                    dtpStartDate.Value = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                    dtpEndDate.Value = dtpStartDate.Value.AddDays(6);
                    break;
                case "This Month":
                    dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    dtpEndDate.Value = dtpStartDate.Value.AddMonths(1).AddDays(-1);
                    break;
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            SalesService salesService = new SalesService();

            DataTable filteredData = salesService.SearchSales(searchTerm);
            dgvSales.DataSource = filteredData;
        }


    }
}
