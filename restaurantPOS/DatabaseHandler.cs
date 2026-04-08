using Microsoft.Data.Sqlite;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Security.Policy;
using System.Text;
using System.Xml.Linq;

namespace restaurantPOS
{
    public class orderItem
    {
        public string itemName;
        public int quantity;
        public decimal price;
        public int orderItemID;
        public string modifications;

        public override string ToString()
        {
            return $"{itemName} - ${price}";
        }
    }

    public struct employee
    {
        public string name;
        public int employeeID;
        public string role;
        public decimal pay;
    }

    public struct itemSales
    {
        public string menuItem;
        public int quantity;
        public decimal totalSales;
    }

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
                    role TEXT NOT NULL,
                    pay DECIMAL(5, 2) NOT NULL
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
                itemTotalPrice DECIMAL(8, 2),
                modifications TEXT
                );
                ";
            command.ExecuteNonQuery();

            command.CommandText = // Payments Table
                @"
                CREATE TABLE IF NOT EXISTS Payments (
                paymentID INTEGER PRIMARY KEY,
                orderID INTEGER,    
                amount DECIMAL(12, 2),
                paymentMethod TEXT
                );
                ";
            command.ExecuteNonQuery();
        }

        public static void addEmployee(int employeeID, string name, string role, decimal pay)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "INSERT INTO Employees VALUES (@id, @name, @role, @pay)";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@id", employeeID);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@role", role);
            command.Parameters.AddWithValue("@pay", pay);

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
            List<string> categories = new List<string>();

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

        public static int OrderExists(int tableNum) // Check if order exists for given table.
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT EXISTS (SELECT 1 FROM Orders WHERE tableNumber = @table AND status = 'Open')";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@table", tableNum);

            int queryResult = Convert.ToInt32((long)command.ExecuteScalar());

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
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT price FROM MenuItems WHERE itemName = @itemName";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("itemName", menuItemName);

            decimal price = Convert.ToDecimal(command.ExecuteScalar());
            int quantity = 1;

            sqlString = "INSERT INTO orderItems (orderID, menuItem, quantity, unitPrice, itemTotalPrice) VALUES (@orderID, @menuItem, @quantity, @price, @totalPrice)";

            using SqliteCommand command2 = new SqliteCommand(sqlString, connection);
            command2.Parameters.AddWithValue("@orderID", orderNum);
            command2.Parameters.AddWithValue("@menuItem", menuItemName);
            command2.Parameters.AddWithValue("@quantity", quantity);
            command2.Parameters.AddWithValue("@price", price);
            command2.Parameters.AddWithValue("@totalPrice", (quantity * price));
            command2.ExecuteNonQuery();
        }

        public static string GetEmployeeName(int employeeID)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT name FROM Employees WHERE employeeID = @employeeID";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@employeeID", employeeID);

            string result = (string)command.ExecuteScalar();
            return result;
        }

        public static int GetOpenOrderNum(int tableNum)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT orderID FROM Orders WHERE tableNumber = @table AND status = 'Open'";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@table", tableNum);

            int queryResult = Convert.ToInt32((long)command.ExecuteScalar());

            return queryResult;
        }



        public static List<orderItem> GetOrderedItems(int orderNum)
        {
            List<orderItem> items = new List<orderItem>();

            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT menuItem, unitPrice, quantity, orderItemID, modifications FROM orderItems WHERE orderID = @orderID";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@orderID", orderNum);
            using var databaseReader = command.ExecuteReader();

            while (databaseReader.Read())
            {
                orderItem item = new orderItem
                {
                    itemName = databaseReader["menuItem"].ToString(),
                    quantity = Convert.ToInt32(databaseReader["quantity"]),
                    price = Convert.ToDecimal(databaseReader["unitPrice"]),
                    orderItemID = Convert.ToInt32(databaseReader["orderItemID"]),
                    modifications = databaseReader["modifications"].ToString()
                };

                items.Add(item);
            }

            return items;
        }

        public static void RemoveItemFromOrder(int orderedItemID)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "DELETE FROM orderItems WHERE orderItemID = @orderedItemID";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@orderedItemID", orderedItemID);
            command.ExecuteNonQuery();
        }

        public static void AddModification(int orderedItemID, string modification)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "UPDATE orderItems SET modifications = @modification WHERE orderItemID = @orderItemID";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@modification", modification);
            command.Parameters.AddWithValue("@orderItemID", orderedItemID);
            command.ExecuteNonQuery();
        }

        public static void updateOrderTotal(int orderID)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT * FROM orderItems WHERE orderID = @orderID";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@orderID", orderID);
            using var databaseReader = command.ExecuteReader();

            decimal sum = 0;

            while (databaseReader.Read())
            {
                sum += Convert.ToDecimal(databaseReader["itemTotalPrice"]);
            }

            string sqlString2 = "UPDATE Orders SET total = @total WHERE orderID = @orderID";

            using SqliteCommand command2 = new SqliteCommand(sqlString2, connection);
            command2.Parameters.AddWithValue("@total", sum);
            command2.Parameters.AddWithValue("@orderID", orderID);
            command2.ExecuteNonQuery();
        }

        public static decimal GetOrderTotal(int orderID)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT total FROM Orders WHERE orderID = @orderID";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@orderID", orderID);
            decimal total = Convert.ToDecimal(command.ExecuteScalar());

            return total;
        }

        public static void CloseCheck(int orderID)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "UPDATE Orders SET status = 'Closed' WHERE orderID = @orderID";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.ExecuteNonQuery();
        }

        public static int VerifyOpenTableOwner(int tableNum, int employeeNum) // Checks if table's open order belongs to given employee
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT EXISTS (SELECT 1 FROM Orders WHERE tableNumber = @tableNum AND status = 'Open' AND employeeID = @employeeNum)";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@tableNum", tableNum);
            command.Parameters.AddWithValue("@employeeNum", employeeNum);
            int queryResult = Convert.ToInt32((long)command.ExecuteScalar());

            return queryResult;
        }

        public static string GetEmployeeType(int employeeNum)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT role FROM Employees where employeeID = @employeeNum";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@employeeNum", employeeNum);
            string result = (string)command.ExecuteScalar();

            return result;
        }

        public static decimal GetAppliedPayments(int orderNum)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();
            string sqlString = "SELECT amount FROM Payments WHERE orderID = @orderNum";
            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@orderNum", orderNum);
            using var databaseReader = command.ExecuteReader();
            decimal sum = 0;
            while (databaseReader.Read())
            {
                sum += Convert.ToDecimal(databaseReader["amount"]);
            }
            return sum;
        }

        public static void ApplyPayment(int orderNum, decimal amount, string paymentType)
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();
            string sqlString = "INSERT INTO Payments (orderID, amount, paymentMethod) VALUES (@orderNum, @amount, @paymentType)";
            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@orderNum", orderNum);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@paymentType", paymentType);
            command.ExecuteNonQuery();
        }

        public static Dictionary<int, decimal> GetSalesByEmployee() // Return a dictionary of closed check sales per employee.
        {
            Dictionary<int, decimal> salesByEmployee = new Dictionary<int, decimal>();

            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = @"SELECT employeeID, SUM(total) as totalSales FROM Orders WHERE status = 'Closed' GROUP BY employeeID";
            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            using var databaseReader = command.ExecuteReader();

            while(databaseReader.Read())
            {
                int employeeID = Convert.ToInt32(databaseReader["employeeID"]);
                decimal totalSales = Convert.ToDecimal(databaseReader["totalSales"]);
                salesByEmployee[employeeID] = totalSales;
            }

            return salesByEmployee;
        }

        public static List<itemSales> GetSalesByItem()
        {
            List<itemSales> salesByCategory = new List<itemSales>();

            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = @"SELECT menuItem, SUM(itemTotalPrice) as itemSales, SUM(quantity) as itemQuantity FROM orderItems GROUP BY menuItem";
            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            using var databaseReader = command.ExecuteReader();

            while (databaseReader.Read()) {
                itemSales item = new itemSales();
                item.menuItem = "" + databaseReader["menuItem"];
                item.totalSales = Convert.ToDecimal(databaseReader["itemSales"]);
                item.quantity = Convert.ToInt32(databaseReader["itemQuantity"]);
                salesByCategory.Add(item);
            }
            return salesByCategory;
        }

        public static int EmployeeExists(int employeeNum) // Check if employee exists..
        {
            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT EXISTS (SELECT 1 FROM Employees WHERE employeeID = @employeeNum)";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            command.Parameters.AddWithValue("@employeeNum", employeeNum);

            int queryResult = Convert.ToInt32((long)command.ExecuteScalar());

            return queryResult;
        }

        public static List<employee> GetAllEmployees()
        {
            List<employee> employees = new List<employee>();

            using var connection = new SqliteConnection("Data Source=pos.db");
            connection.Open();

            string sqlString = "SELECT employeeID, name, role, pay FROM Employees";

            using SqliteCommand command = new SqliteCommand(sqlString, connection);
            using var databaseReader = command.ExecuteReader();

            while (databaseReader.Read())
            {
                employee employeeToAdd = new employee
                {
                    employeeID = Convert.ToInt32(databaseReader["employeeID"]),
                    name = databaseReader["name"].ToString(),
                    pay = Convert.ToDecimal(databaseReader["pay"]),
                    role = databaseReader["role"].ToString()
                };

                employees.Add(employeeToAdd);
            }

            return employees;
        }
    }
}

