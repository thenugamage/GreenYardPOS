using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class DiscountService
    {
        public bool AddDiscount(string discountName, decimal discountAmount, DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddDiscount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DiscountName", discountName);
                        cmd.Parameters.AddWithValue("@DiscountAmount", discountAmount);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

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

        public bool DeleteDiscount(int discountId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteDiscount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DiscountID", discountId);
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

        public DataTable SearchDiscount(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchDiscount", conn))
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

        public DataTable GetDiscountDetails()
        {
            DataTable discountDetails = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_DiscountDetails", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            discountDetails.Load(reader);
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
            return discountDetails;
        }

        public decimal GetDiscountAmountById(int discountID)
        {
            decimal discountAmount = 0;

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT dbo.GetDiscountAmountById(@DiscountID)"; 

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DiscountID", discountID);
                        
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            discountAmount = Convert.ToDecimal(result); 
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

            return discountAmount;
        }

    }
}
