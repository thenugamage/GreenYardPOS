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
    public partial class Categories : UserControl
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Example of navigating to AddNewCategory user control
            Add_New_Categorey addNewCategory = new Add_New_Categorey();
            this.Controls.Add(addNewCategory);
            addNewCategory.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            // Bring Panel1 to the front
            panel1.BringToFront();

            // Create an instance of the Add_New_Categorey user control
            Add_New_Categorey addNewCategory = new Add_New_Categorey();

            // Load the Add_New_Categorey user control inside Panel1
            panel1.Controls.Clear(); // Clear existing controls if needed
            panel1.Controls.Add(addNewCategory);
        }


        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
