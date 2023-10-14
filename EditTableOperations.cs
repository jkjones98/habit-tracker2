using System.Collections;
using System.Security.Cryptography.X509Certificates;
using habit_tracker2;
using Microsoft.Data.Sqlite;

namespace EditTableOperations;

public class Operations
{
    string connectionString = @"Data Source=habit-Tracker2.db";

    public Operations()
    {

    }

    public void EditTableSwitch(int op)
    {
        switch (op)
        {
            case 0:
                // Not even sure this is necessary but funny so keeping it
                Console.WriteLine("Closing application switch case");
                break;
            case 1:
                SqliteDataReader sqliteReader;
                Console.WriteLine("View all records switch case");
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    var tableCommand = connection.CreateCommand();

                    tableCommand.CommandText = "SELECT * FROM drinking_water";

                    // Don't return any values, not querying any values
                    tableCommand.ExecuteNonQuery();

                    sqliteReader = tableCommand.ExecuteReader();
                    while (sqliteReader.Read())
                    {
                        string dbReader = sqliteReader.GetString(0);
                        Console.WriteLine(dbReader);
                    }

                    // Get the number of columns in the database using the below
                    string numOfColumns = tableCommand.CommandText = "SELECT COUNT(*) FROM pragma_table_info('drinking_water')";
                    /* 
                    for(int i = 0; i < ;)
                    {

                    }
                    */
                    connection.Close();
                }
                break;
            case 2:
                Insert();
                break;
            case 3:
                // Need to look up code to delete records, shouldn't be too hard
                // Will probably be like DELETE * FROM drinking_Water WHERE Id (x)
                Console.WriteLine("Delete record switch case");
                break;
            case 4:
                // Need to look up code for updating an existing record
                Console.WriteLine("Update record switch case");
                break;
            default:
                break;
        }
    }

    private static void Insert()
    {
        string connectionString = @"Data Source=habit-Tracker2.db";

        string date = GetDateInput();
        int quantity = GetQuantityInput();

        Console.WriteLine("Insert Record switch case");
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var tableCommand = connection.CreateCommand();

            tableCommand.CommandText = $"INSERT INTO drinking_water(Date, Quantity) VALUES('{date}', {quantity})";

            // Don't return any values, not querying any values
            tableCommand.ExecuteNonQuery();

            connection.Close();
        }
    }

    internal static string GetDateInput()
    {
        Console.WriteLine("\n\nInsert the date using the following format DD-MM-YYYY. Enter 0 to return to the main menu.");

        string dateInput = Console.ReadLine();

        return dateInput;
    }

    internal static int GetQuantityInput()
    {
        Console.WriteLine("\n\nEnter the number of litres you have drank today, no decimals. Enter 0 to return to the main menu");

        string litresInput = Console.ReadLine();
        
        int cleanInput = Convert.ToInt32(litresInput);

        return cleanInput;
    }
}