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
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //navigate to AddNewEmployee.cs user control
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.Dock = DockStyle.Fill;
            this.Controls.Add(addNewEmployee);
            addNewEmployee.BringToFront();

        }
    }
}
