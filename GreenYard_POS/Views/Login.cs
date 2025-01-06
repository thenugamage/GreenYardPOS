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
using GreenYard_POS.Views;
using GreenYard_POS.Views.Stages;

namespace GreenYard_POS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            int id;
            string pass = txtPassword.Text;
            
            if (int.TryParse(txtID.Text, out id))
            {
                EmployeeService employeeService = new EmployeeService();

                bool isLoginSuccessful = employeeService.Login(id, pass);

                if (isLoginSuccessful)
                {
                    this.Hide();

                    dashboard dashboardForm = new dashboard();
                    dashboardForm.FormClosed += DashboardForm_FormClosed; //Program stop when exit from dashboard form
                    dashboardForm.Show();

                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Invalid credentials, please try again.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close application when dashboard closed
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }
    }
}
