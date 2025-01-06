using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GreenYard_POS.Services
{
    public class BillProduct
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public BillProduct(int productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }

    class BillService
    {

        public int AddBill(int customerId, int empId, decimal totalAmount, decimal netAmount,
                     int? discountId, List<BillProduct> products)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddBill", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable productsTable = new DataTable();
                        productsTable.Columns.Add("ProductID", typeof(int));
                        productsTable.Columns.Add("Quantity", typeof(int));

                        foreach (var product in products)
                        {
                            productsTable.Rows.Add(product.ProductId, product.Quantity);
                        }

                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.Parameters.AddWithValue("@EmpID", empId);  // Added EmpID parameter
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@NetAmount", netAmount);
                        cmd.Parameters.AddWithValue("@DiscountID", (object)discountId ?? DBNull.Value);
                        SqlParameter productsParam = cmd.Parameters.Add("@Products", SqlDbType.Structured);
                        productsParam.Value = productsTable;
                        productsParam.TypeName = "BillProductsType";

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding bill: {ex.Message}");
                    throw;
                }
            }
            return -1;
        }

        public DataTable GetCustomerDetails()
        {
            DataTable customerDetails = new DataTable();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    
                    string query = @"
                SELECT 
                    ID, 
                    (FirstName + ' ' + LastName) AS FullName 
                FROM Customer";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            customerDetails.Load(reader);
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
            return customerDetails;
        }

        public decimal GetProductUnitPrice(int productId)
        {
            decimal unitPrice = 0;

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT UnitPrice FROM Product WHERE ProductID = @ProductID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);

                        object result = cmd.ExecuteScalar();
                        if (result != null && decimal.TryParse(result.ToString(), out unitPrice))
                        {
                            return unitPrice;
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

            return unitPrice;
        }

        public DataTable GetAllProducts()
        {
            DataTable products = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT p.ProductID, p.ProductName FROM Product p INNER JOIN StockQty sq ON p.ProductID = sq.ProductID; ", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            products.Load(reader);
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

            return products;
        }

        public DataTable GetAllDiscounts()
        {
            DataTable discountTable = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DiscountID, DiscountName FROM Discount";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            discountTable.Load(reader); // Load data from the reader into the DataTable
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    // You could also log the error to a file or database if needed
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return discountTable;
        }

    }
}
