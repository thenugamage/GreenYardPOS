﻿using System;
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
    public partial class Supplier_Success_Massage : Form
    {
        public Supplier_Success_Massage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //navigate to the Suplier.cs page
            Suplier supplier = new Suplier();
            supplier.Show();
            this.Hide();


        }
    }
}
