using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            command.CommandText = // Employees Table
                @"
                CREATE TABLE IF NOT EXISTS Employees (
                    employeeID INTEGER PRIMARY KEY,
                    name TEXT NOT NULL,
                    role TEXT NOT NULL
                    );
                ";
            command.ExecuteNonQuery();

            command.CommandText = // Menu Items Table
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

            command.CommandText = // Orders Table
                @"
                CREATE TABLE IF NOT EXISTS Orders ( 
                orderID INTEGER PRIMARY KEY,
                employeeID INTEGER,
                tableNumber INTEGER,
                status TEXT,
                total DECIMAL(12, 2)
                );
                ";
            command.ExecuteNonQuery();

            command.CommandText = // Ordered Items Table
                @"
                CREATE TABLE IF NOT EXISTS orderItems (
                orderItemID INTEGER PRIMARY KEY,
                orderID INTEGER,
                menuItem TEXT,
                quantity INTEGER,
                unitPrice DECIMAL(6, 2),
                itemTotalPrice DECIMAL(8, 2)
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

        public static List<string> GetCategoryNames()
        {
            List<string> categories = new List<string>(); // HashSet used so that duplicate categories are not created.

            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                @"
                SELECT DISTINCT category 
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
        
        public static int OrderExists(int employeeID, int tableNum)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT EXISTS (SELECT 1 FROM Orders WHERE tableNumber = @table AND status = 'Open')";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@table", tableNum);

            int queryResult = Convert.ToInt32((long) command.ExecuteScalar());

            return queryResult;
        }

        public static void CreateOrder(int employeeID, int tableNum) // Call this when OrderExists returns value indicating no open order found.
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "INSERT INTO Orders (employeeID, tableNumber, status) VALUES (@employeeID, @tableNum, 'Open')";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            command.Parameters.AddWithValue("@tableNum", tableNum);
            command.ExecuteNonQuery();
        }
        public static void AddItemToOrder(int tableNum, string menuItemName, int orderNum)
        {
             
        }


    }
}
