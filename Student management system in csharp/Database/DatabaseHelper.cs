using System;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem.Database
{
    // This class handles all database connections
    // Uses singleton pattern - only one connection throughout app
    class DatabaseHelper
    {
        // MySQL connection string - change password if needed
        private static string connectionString =
            "Server=localhost;Database=StudentManagementDB;Uid=root;Pwd=sehar12345;";

        // Returns a new open connection to the database
        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Database connection failed: " + ex.Message);
            }
        }

        // Test if database is reachable
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}