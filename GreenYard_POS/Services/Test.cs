using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class Test
    {
        public static void testing(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();

            int inputID = 1001;  // Replace with actual ManagerID or CashierID
            string inputPassword = "SecurePass123";  // Replace with actual password

            if (employeeService.Login(inputID, inputPassword))
            {
                Console.WriteLine("Login Successful!");
                Console.WriteLine($"User Name: {Auth.UserName}");
                Console.WriteLine($"Role: {Auth.Role}");
                Console.WriteLine($"Role ID: {Auth.RoleID}");
            }
            else
            {
                Console.WriteLine("Login Failed. Invalid credentials.");
            }
        }
    }
}
