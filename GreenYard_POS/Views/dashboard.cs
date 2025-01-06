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
using GreenYard_POS.Views.Scenes;

namespace GreenYard_POS.Views
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            lblUsrName.Text = Auth.UserName;
            lblUsrName.TextAlign = ContentAlignment.MiddleRight;

            lblRole.Text = Auth.Role;
            lblRole.TextAlign = ContentAlignment.MiddleRight;

            if (Auth.Role.ToLower() != "manager")
            {
                btnCategories.Enabled = false;
                btnProducts.Enabled = false;
                btnSuppliers.Enabled = false;
                btnStocks.Enabled = false;
                btnDiscounts.Enabled = false;
                btnSales.Enabled = false;
            }
        }

        // For load subforms in to mainPanel
        private void LoadFormIntoPanel(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void lblUsrName_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Customers";
            Customers customers = new Customers();
            LoadFormIntoPanel(customers);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Categories";
            Categories categories = new Categories();
            LoadFormIntoPanel(categories);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Products";
            Products products = new Products();
            LoadFormIntoPanel(products);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Suppliers";
            Suppliers suppliers = new Suppliers();
            LoadFormIntoPanel(suppliers);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Stocks";
            Stocks stocks = new Stocks();
            LoadFormIntoPanel(stocks);
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Discounts";
            Discounts discounts = new Discounts();
            LoadFormIntoPanel(discounts);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Bills";
            Bills bills = new Bills();
            LoadFormIntoPanel(bills);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Sales";
            Sales sales = new Sales();
            LoadFormIntoPanel(sales);
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Employees";
            Employees employees = new Employees();
            LoadFormIntoPanel(employees);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Auth.Role = null;
            Auth.RoleID = 0;
            Auth.UserName = null;

            this.Hide();

            Login login = new Login();
            login.Show();
        }
    }
}
