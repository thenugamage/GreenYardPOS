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
    public partial class AddNewEmployee : UserControl
    {
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //navigate back to Employee.cs user control
            Employee employee = new Employee();
            employee.Dock = DockStyle.Fill;
            this.Controls.Add(employee);
            employee.BringToFront();

        }

        private void AddNewEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
