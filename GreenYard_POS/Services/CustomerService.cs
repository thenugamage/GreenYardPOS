using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class CustomerService
    {
        public bool AddCustomer(string firstName, string lastName, string contactNum, string nic)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                       
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@ContactNum", contactNum);
                        cmd.Parameters.AddWithValue("@NIC", nic);

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
        
        public bool DeleteCustomer(int customerId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                       
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                       
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

        public DataTable GetAllCustomers()
        {
            DataTable customersTable = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_AllCustomers", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            customersTable.Load(reader);
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
            return customersTable;
        }

        public DataTable SearchCustomer(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchCustomer", conn))
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
