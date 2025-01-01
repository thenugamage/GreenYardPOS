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
    public partial class Add_New_Categorey : UserControl
    {
        public Add_New_Categorey()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Assuming the parent control is a Form or another UserControl
            var parent = this.Parent;

            if (parent != null)
            {
                // Create an instance of the Categories user control
                var categoriesControl = new Categories();

                // Clear existing controls and add the new user control
                parent.Controls.Clear();
                parent.Controls.Add(categoriesControl);
                categoriesControl.Dock = DockStyle.Fill;
            }
        }

        private void Add_New_Categorey_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //navigate to Categories user control
            Categories categories = new Categories();
            this.Controls.Add(categories);
            categories.BringToFront();

        }
    }
}
