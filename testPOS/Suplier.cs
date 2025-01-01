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
    public partial class Suplier : UserControl
    {
        public Suplier()
        {
            InitializeComponent();
        }

        private void Suplier_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //navigate to AddNewSuplier.cs user control
            AddNewSupliers addNewSuplier = new AddNewSupliers();
            addNewSuplier.Dock = DockStyle.Fill;
            this.Controls.Add(addNewSuplier);
            addNewSuplier.BringToFront();


        }

        private void label6_Click(object sender, EventArgs e)
        {
            //navigate to AddNewSupplier.cs user control
            AddNewSupliers addNewSupplier = new AddNewSupliers();
            addNewSupplier.Dock = DockStyle.Fill;
            this.Controls.Add(addNewSupplier);
            addNewSupplier.BringToFront();

        }
    }
}
