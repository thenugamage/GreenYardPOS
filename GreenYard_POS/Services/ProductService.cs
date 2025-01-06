using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class ProductService
    {

        public bool AddProduct(string productName, string unit, decimal unitPrice, string productDetails, int categoryId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Unit", unit ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@ProductDetails", productDetails ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId > 0 ? (object)categoryId : DBNull.Value);

                        cmd.ExecuteNonQuery();
                        return true; // Product added successfully
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

        public bool DeleteProduct(int productId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", productId);

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

        public DataTable GetAllProducts()
        {
            DataTable productsTable = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_AllProducts", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            productsTable.Load(reader);
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
            return productsTable;
        }

        public DataTable SearchProduct(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchProduct", conn))
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

        public DataTable GetCategories()
        {
            DataTable categoriesTable = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT CategoryID, CategoryName FROM Category", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            categoriesTable.Load(reader);
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

            return categoriesTable;
        }

    }
}
