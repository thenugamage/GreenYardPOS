using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenYard_POS.Services
{
    class DBConnection
    {
        private static readonly string connectionString = "Server=THENURI\\SQLEXPRESS01;Database=GreenYardPOS;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                LogError("Error creating connection", ex);
                throw new InvalidOperationException("Could not establish a connection to the database.", ex);
            }
        }

        private static void LogError(string message, Exception ex)
        {
            Console.WriteLine($"[ERROR] {message}: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        }

    }
}
