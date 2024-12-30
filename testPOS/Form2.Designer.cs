namespace testPOS
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            SalesReportsBtn = new Button();
            button12 = new Button();
            BillsBtn = new Button();
            button11 = new Button();
            SalesBtn = new Button();
            StocksBtn = new Button();
            CustomersBtn = new Button();
            SuppliersBtn = new Button();
            ProductsBtn = new Button();
            DiscountsBtn = new Button();
            CategoriesBtn = new Button();
            mainpanl = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1862, 69);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(57, 116, 120);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(256, 54);
            label2.TabIndex = 2;
            label2.Text = "GREENYARD";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1610, 15);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 1;
            label1.Text = "Admin Name";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1776, 3);
            button1.Name = "button1";
            button1.Size = new Size(61, 57);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(SalesReportsBtn);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(BillsBtn);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(SalesBtn);
            panel2.Controls.Add(StocksBtn);
            panel2.Controls.Add(CustomersBtn);
            panel2.Controls.Add(SuppliersBtn);
            panel2.Controls.Add(ProductsBtn);
            panel2.Controls.Add(DiscountsBtn);
            panel2.Controls.Add(CategoriesBtn);
            panel2.Location = new Point(-8, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 918);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // SalesReportsBtn
            // 
            SalesReportsBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesReportsBtn.FlatAppearance.BorderSize = 0;
            SalesReportsBtn.FlatStyle = FlatStyle.Flat;
            SalesReportsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SalesReportsBtn.ForeColor = Color.White;
            SalesReportsBtn.Location = new Point(9, 644);
            SalesReportsBtn.Name = "SalesReportsBtn";
            SalesReportsBtn.Size = new Size(312, 78);
            SalesReportsBtn.TabIndex = 25;
            SalesReportsBtn.Text = "Sales Reports";
            SalesReportsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SalesReportsBtn.UseVisualStyleBackColor = false;
            SalesReportsBtn.Click += SalesReportsBtn_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button12.BackColor = Color.FromArgb(36, 54, 66);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(159, 791);
            button12.Name = "button12";
            button12.Size = new Size(119, 40);
            button12.TabIndex = 16;
            button12.Text = "Log Out";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // BillsBtn
            // 
            BillsBtn.BackColor = Color.FromArgb(36, 54, 66);
            BillsBtn.FlatAppearance.BorderSize = 0;
            BillsBtn.FlatStyle = FlatStyle.Flat;
            BillsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BillsBtn.ForeColor = Color.White;
            BillsBtn.Location = new Point(9, 566);
            BillsBtn.Name = "BillsBtn";
            BillsBtn.Size = new Size(312, 78);
            BillsBtn.TabIndex = 24;
            BillsBtn.Text = "Bills";
            BillsBtn.TextAlign = ContentAlignment.MiddleLeft;
            BillsBtn.UseVisualStyleBackColor = false;
            BillsBtn.Click += BillsBtn_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.BackColor = Color.FromArgb(36, 54, 66);
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(101, 785);
            button11.Name = "button11";
            button11.Size = new Size(50, 52);
            button11.TabIndex = 15;
            button11.UseVisualStyleBackColor = false;
            // 
            // SalesBtn
            // 
            SalesBtn.BackColor = Color.FromArgb(36, 54, 66);
            SalesBtn.FlatAppearance.BorderSize = 0;
            SalesBtn.FlatStyle = FlatStyle.Flat;
            SalesBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SalesBtn.ForeColor = Color.White;
            SalesBtn.Location = new Point(9, 488);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(312, 78);
            SalesBtn.TabIndex = 23;
            SalesBtn.Text = "Sales";
            SalesBtn.TextAlign = ContentAlignment.MiddleLeft;
            SalesBtn.UseVisualStyleBackColor = false;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // StocksBtn
            // 
            StocksBtn.BackColor = Color.FromArgb(36, 54, 66);
            StocksBtn.FlatAppearance.BorderSize = 0;
            StocksBtn.FlatStyle = FlatStyle.Flat;
            StocksBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            StocksBtn.ForeColor = Color.White;
            StocksBtn.Location = new Point(9, 410);
            StocksBtn.Name = "StocksBtn";
            StocksBtn.Size = new Size(312, 78);
            StocksBtn.TabIndex = 22;
            StocksBtn.Text = "Stocks";
            StocksBtn.TextAlign = ContentAlignment.MiddleLeft;
            StocksBtn.UseVisualStyleBackColor = false;
            StocksBtn.Click += StocksBtn_Click;
            // 
            // CustomersBtn
            // 
            CustomersBtn.BackColor = Color.FromArgb(36, 54, 66);
            CustomersBtn.FlatAppearance.BorderSize = 0;
            CustomersBtn.FlatStyle = FlatStyle.Flat;
            CustomersBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomersBtn.ForeColor = Color.White;
            CustomersBtn.Location = new Point(9, 20);
            CustomersBtn.Name = "CustomersBtn";
            CustomersBtn.Size = new Size(312, 78);
            CustomersBtn.TabIndex = 17;
            CustomersBtn.Text = "Customers";
            CustomersBtn.TextAlign = ContentAlignment.MiddleLeft;
            CustomersBtn.UseVisualStyleBackColor = false;
            CustomersBtn.Click += button13_Click;
            // 
            // SuppliersBtn
            // 
            SuppliersBtn.BackColor = Color.FromArgb(36, 54, 66);
            SuppliersBtn.FlatAppearance.BorderSize = 0;
            SuppliersBtn.FlatStyle = FlatStyle.Flat;
            SuppliersBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SuppliersBtn.ForeColor = Color.White;
            SuppliersBtn.Location = new Point(9, 332);
            SuppliersBtn.Name = "SuppliersBtn";
            SuppliersBtn.Size = new Size(312, 78);
            SuppliersBtn.TabIndex = 21;
            SuppliersBtn.Text = "Suppliers";
            SuppliersBtn.TextAlign = ContentAlignment.MiddleLeft;
            SuppliersBtn.UseVisualStyleBackColor = false;
            SuppliersBtn.Click += SuppliersBtn_Click;
            // 
            // ProductsBtn
            // 
            ProductsBtn.BackColor = Color.FromArgb(36, 54, 66);
            ProductsBtn.FlatAppearance.BorderSize = 0;
            ProductsBtn.FlatStyle = FlatStyle.Flat;
            ProductsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ProductsBtn.ForeColor = Color.White;
            ProductsBtn.Location = new Point(9, 98);
            ProductsBtn.Name = "ProductsBtn";
            ProductsBtn.Size = new Size(312, 78);
            ProductsBtn.TabIndex = 18;
            ProductsBtn.Text = "Products";
            ProductsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ProductsBtn.UseVisualStyleBackColor = false;
            ProductsBtn.Click += button14_Click;
            // 
            // DiscountsBtn
            // 
            DiscountsBtn.BackColor = Color.FromArgb(36, 54, 66);
            DiscountsBtn.FlatAppearance.BorderSize = 0;
            DiscountsBtn.FlatStyle = FlatStyle.Flat;
            DiscountsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DiscountsBtn.ForeColor = Color.White;
            DiscountsBtn.Location = new Point(9, 254);
            DiscountsBtn.Name = "DiscountsBtn";
            DiscountsBtn.Size = new Size(312, 78);
            DiscountsBtn.TabIndex = 20;
            DiscountsBtn.Text = "Discounts";
            DiscountsBtn.TextAlign = ContentAlignment.MiddleLeft;
            DiscountsBtn.UseVisualStyleBackColor = false;
            DiscountsBtn.Click += DiscountsBtn_Click;
            // 
            // CategoriesBtn
            // 
            CategoriesBtn.BackColor = Color.FromArgb(36, 54, 66);
            CategoriesBtn.FlatAppearance.BorderSize = 0;
            CategoriesBtn.FlatStyle = FlatStyle.Flat;
            CategoriesBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CategoriesBtn.ForeColor = Color.White;
            CategoriesBtn.Location = new Point(9, 176);
            CategoriesBtn.Name = "CategoriesBtn";
            CategoriesBtn.Size = new Size(312, 78);
            CategoriesBtn.TabIndex = 19;
            CategoriesBtn.Text = "Categories";
            CategoriesBtn.TextAlign = ContentAlignment.MiddleLeft;
            CategoriesBtn.UseVisualStyleBackColor = false;
            CategoriesBtn.Click += CategoriesBtn_Click;
            // 
            // mainpanl
            // 
            mainpanl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainpanl.Location = new Point(328, 80);
            mainpanl.Name = "mainpanl";
            mainpanl.Size = new Size(1537, 913);
            mainpanl.TabIndex = 2;
            mainpanl.Paint += panel3_Paint_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 54, 66);
            ClientSize = new Size(1881, 1008);
            Controls.Add(mainpanl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NAv";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button11;
        private Button button12;
        private Label label2;
        private Button CustomersBtn;
        private Button ProductsBtn;
        private Button CategoriesBtn;
        private Button StocksBtn;
        private Button SuppliersBtn;
        private Button DiscountsBtn;
        private Button SalesReportsBtn;
        private Button BillsBtn;
        private Button SalesBtn;
        private Panel mainpanl;
    }
}