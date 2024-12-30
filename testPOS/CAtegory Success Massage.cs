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
    public partial class CAtegory_Success_Massage : Form
    {
        public CAtegory_Success_Massage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Assuming you have a Categories user control named 'categoriesUserControl'
            Categories categoriesUserControl = new Categories();

            // Assuming you have a panel or some container to hold the user control
            this.Controls.Clear(); // Clear current controls
            this.Controls.Add(categoriesUserControl); // Add the Categories user control
            categoriesUserControl.Dock = DockStyle.Fill; // Optional: Dock the user control to fill the container
        }
    }
}
