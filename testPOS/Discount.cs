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
    public partial class Discount : UserControl
    {
        public Discount()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            // Bring Panel1 to the front
            panel1.BringToFront();

            // Create an instance of the Add_New_Categorey user control
            AddNewDiscount addNewCategory = new AddNewDiscount();

            // Load the Add_New_Categorey user control inside Panel1
            panel1.Controls.Clear(); // Clear existing controls if needed
            panel1.Controls.Add(addNewCategory);
        }
    }
}
