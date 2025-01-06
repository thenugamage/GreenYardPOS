using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class SupplierService
    {
        // Add Supplier
        public bool AddSupplier(string supplierName, string contact, int categoryId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertSupplier", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        cmd.Parameters.AddWithValue("@Contact", string.IsNullOrEmpty(contact) ? (object)DBNull.Value : contact);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId > 0 ? (object)categoryId : DBNull.Value);

                        cmd.ExecuteNonQuery();
                        return true; // Supplier added successfully
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

        // Delete Supplier
        public bool DeleteSupplier(int supplierId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteSupplier", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);

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

        // Get All Suppliers
        public DataTable GetAllSuppliers()
        {
            DataTable suppliersTable = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_SupplierProducts", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            suppliersTable.Load(reader);
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
            return suppliersTable;
        }

        // Search Suppliers
        public DataTable SearchSuppliers(string searchTerm)
        {
            DataTable searchResults = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SearchSupplier", conn))
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

        // Get Categories for Supplier
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

        public bool AddSupplierProduct(int supplierId, int productId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddSupplierProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@ProductID", productId);

                        cmd.ExecuteNonQuery();
                        return true; // Supplier product association added successfully
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

        public bool DeleteSupplierProduct(int supplierId, int productId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteSupplierProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@ProductID", productId);

                        cmd.ExecuteNonQuery();
                        return true; // Supplier product association deleted successfully
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

        public DataTable GetSuppliers()
        {
            DataTable suppliersTable = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT SupplierID, SupplierName FROM Supplier", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            suppliersTable.Load(reader);
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

            return suppliersTable;
        }

        public DataTable GetProducts()
        {
            DataTable productsTable = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName FROM Product", conn))
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
    }
}
