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
    public partial class AddNewSupliers : UserControl
    {
        public AddNewSupliers()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //navigate back to Suplier.cs user control
            Suplier suplier = new Suplier();
            suplier.Dock = DockStyle.Fill;
            this.Controls.Add(suplier);
            suplier.BringToFront();

        }
    }
}
