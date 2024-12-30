using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            welcome userControl = new welcome();
            this.mainpanl.Controls.Clear(); //
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Product userControl = new Product();
            this.mainpanl.Controls.Clear(); //
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(57, 120, 142);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controls.UserControlcostomers userControl = new controls.UserControlcostomers();
            this.Controls.Clear();
            this.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // navigate to customer usercontrol in to mainpanl
            Customer userControl = new Customer();
            this.mainpanl.Controls.Clear(); //
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(57, 120, 142);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            Categories userControl = new Categories();
            this.mainpanl.Controls.Clear(); //
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(57, 120, 142);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);
        }

        private void DiscountsBtn_Click(object sender, EventArgs e)
        {
            Discount userControl = new Discount();
            this.mainpanl.Controls.Clear(); //
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(57, 120, 142);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);
        }

        private void SuppliersBtn_Click(object sender, EventArgs e)
        {
            Suplier userControl = new Suplier();
            this.mainpanl.Controls.Clear();
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(57, 120, 142);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);
        }

        private void StocksBtn_Click(object sender, EventArgs e)
        {
            Stock userControl = new Stock();
            this.mainpanl.Controls.Clear();
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(57, 120, 142);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            Sales userControl = new Sales();
            this.mainpanl.Controls.Clear();
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(57, 120, 142);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);
        }

        private void BillsBtn_Click(object sender, EventArgs e)
        {
            Bills userControl = new Bills();
            this.mainpanl.Controls.Clear();
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(57, 120, 142);
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);
        }

        private void SalesReportsBtn_Click(object sender, EventArgs e)
        {
            SalesReport userControl = new SalesReport();
            this.mainpanl.Controls.Clear();
            this.mainpanl.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.BackColor = Color.FromArgb(57, 120, 142);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
