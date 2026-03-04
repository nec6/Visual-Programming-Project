using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace restaurantPOS
{
    public static class DatabaseHandler
    {
        public static void Initialize() 
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS Employees (
                    employeeID INTEGER PRIMARY KEY,
                    name TEXT NOT NULL,
                    role TEXT NOT NULL
                    );
                ";

            command.ExecuteNonQuery();

            command.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS MenuItems (
                    menuItemID INTEGER PRIMARY KEY,
                    itemName TEXT NOT NULL,
                    category TEXT NOT NULL,
                    price DECIMAL(6, 2) NOT NULL,
                    liquorTax BOOLEAN
                    );
                ";

            command.ExecuteNonQuery();

        }

        public static void addEmployee(int employeeID, string name, string role)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "INSERT INTO Employees VALUES (@id, @name, @role)";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@id", employeeID);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@role", role);

            command.ExecuteNonQuery();
        }

        public static void removeEmployee(int employeeID)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "DELETE FROM Employees WHERE employeeID=@id";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@id", employeeID);

            command.ExecuteNonQuery();
        }

        public static void addMenuItem(string name, string category, decimal price, bool liquorTax)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "INSERT INTO MenuItems (itemName, category, price, liquorTax) VALUES (@itemName, @category, @price, @liquorTax)";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@itemName", name);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@liquorTax", liquorTax);

            command.ExecuteNonQuery();
        }

        public static HashSet<string> GetCategoryNames()
        {
            HashSet<string> categories = new HashSet<string>(); // HashSet used so that duplicate categories are not created.

            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                @"
                SELECT category 
                FROM MenuItems;
                ";

            using var databaseReader = command.ExecuteReader();
            while (databaseReader.Read())
            {
                categories.Add(databaseReader.GetString(0));
            }

            return categories;
        }

        public static List<string> GetMenuItems(string category)
        {
            List<string> menuItems = new List<string>();

            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT itemName FROM MenuItems WHERE category=@category";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@category", category);

            using var databaseReader = command.ExecuteReader();
            while (databaseReader.Read())
            {
                menuItems.Add(databaseReader.GetString(0));
            }

            return menuItems;
        }
    }
}
