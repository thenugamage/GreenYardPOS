using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class SalesService
    {
        public DataTable GetAllSales()
        {
            DataTable salesData = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_SalesDetails";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            salesData.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
            }

            return salesData;
        }

        public DataTable SearchSales(string searchTerm)
        {
            DataTable salesResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchSales", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            salesResults.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error searching sales: {ex.Message}");
                    throw;
                }
            }
            return salesResults;
        }

        public DataTable GetSalesSummary(DateTime startDate, DateTime endDate)
        {
            DataTable summaryResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetSalesSummary", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            summaryResults.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting sales summary: {ex.Message}");
                    throw;
                }
            }
            return summaryResults;
        }

        public DataTable GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable salesResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetSalesByDateRange", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Date);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            salesResults.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving sales: {ex.Message}");
                    throw;
                }
            }
            return salesResults;
        }

        // Helper method to get monthly sales summary
        public DataTable GetMonthlySalesSummary(int year, int month)
        {
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            return GetSalesSummary(startDate, endDate);
        }

        // Helper method to get daily sales summary
        public DataTable GetDailySalesSummary(DateTime date)
        {
            return GetSalesSummary(date.Date, date.Date);
        }


    }
}
