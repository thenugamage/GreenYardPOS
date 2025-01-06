using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class EmployeeService
    {
        public bool Login(int id, string password)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("LoginEmployee", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@InputID", id);
                        cmd.Parameters.AddWithValue("@InputPassword", password);

                        SqlParameter userNameParam = new SqlParameter("@UserName", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(userNameParam);

                        SqlParameter roleParam = new SqlParameter("@Role", SqlDbType.NVarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(roleParam);

                        SqlParameter roleIDParam = new SqlParameter("@RoleID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(roleIDParam);

                        cmd.ExecuteNonQuery();

                        if (userNameParam.Value != DBNull.Value && roleParam.Value != DBNull.Value && roleIDParam.Value != DBNull.Value)
                        {
                            Auth.UserName = userNameParam.Value.ToString();
                            Auth.Role = roleParam.Value.ToString();
                            Auth.RoleID = Convert.ToInt32(roleIDParam.Value);

                            return true; 
                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"[ERROR] Login failed: {ex.Message}");
                    return false;
                }
            }
        }


        public bool AddEmployee(string firstName, string lastName, string address, string nic, string userPassword, string contactNumbers, string role, int roleId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@UserPassword", userPassword);
                        cmd.Parameters.AddWithValue("@ContactNumbers", ValidateContactNumbers(contactNumbers)); // Ensure proper formatting
                        cmd.Parameters.AddWithValue("@Role", ValidateRole(role)); // Validate role
                        cmd.Parameters.AddWithValue("@RoleID", roleId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex) when (ex.Number == 50000) // Handle RAISERROR from stored procedure
                {
                    Console.WriteLine($"Business Logic Error: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected Error: {ex.Message}");
                    return false;
                }
            }
        }

        // Helper Method: Validate Role
        private string ValidateRole(string role)
        {
            if (role.Equals("Manager", StringComparison.OrdinalIgnoreCase) || role.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
            {
                return role;
            }
            throw new ArgumentException("Invalid role. Role must be 'Manager' or 'Cashier'.");
        }

        // Helper Method: Validate and Format Contact Numbers
        private string ValidateContactNumbers(string contactNumbers)
        {
            if (string.IsNullOrWhiteSpace(contactNumbers))
            {
                throw new ArgumentException("Contact numbers cannot be empty.");
            }

            // Ensure comma-separated format and no invalid characters
            var formattedNumbers = string.Join(",", contactNumbers.Split(',').Select(c => c.Trim()).Where(c => !string.IsNullOrEmpty(c)));
            return formattedNumbers;
        }

        public bool DeleteEmployee(int employeeId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        public DataTable GetAllEmployees()
        {
            DataTable employeesTable = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_AllEmployees", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            employeesTable.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return employeesTable;
        }

        public DataTable SearchEmployee(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            searchResults.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return searchResults;
        }


    }
}

