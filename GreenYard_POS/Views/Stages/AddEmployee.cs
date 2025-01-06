using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreenYard_POS.Services;

namespace GreenYard_POS.Views.Stages
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtAddress.Clear();
            txtNIC.Clear();
            txtPassword.Clear();
            txtRoleID.Clear();
            txtContactNos.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFname.Text.Trim();
                string lastName = txtLname.Text.Trim();
                string address = txtAddress.Text.Trim();
                string nic = txtNIC.Text.Trim();
                string userPassword = txtPassword.Text.Trim();
                string contactNumbers = txtContactNos.Text.Trim();
                string role = cmbRole.SelectedItem.ToString();
                int roleId = int.Parse(txtRoleID.Text.Trim());

                EmployeeService employeeService = new EmployeeService();
                bool isSuccess = employeeService.AddEmployee(firstName, lastName, address, nic, userPassword, contactNumbers, role, roleId);

                if (isSuccess)
                {
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add employee. Please check the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
