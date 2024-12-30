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
            AddNewSupliers addNewCategory = new AddNewSupliers();
            this.Controls.Add(addNewCategory);
            addNewCategory.BringToFront();
        }
    }
}
