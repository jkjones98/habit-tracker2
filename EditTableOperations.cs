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
        switch(op)
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
                    while(sqliteReader.Read())
                    {
                        string dbReader = sqliteReader.GetString(0);
                        Console.WriteLine(dbReader);
                    }
                    connection.Close();
                }
            break;
            case 2:
                Console.WriteLine("Insert Record switch case");
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    var tableCommand = connection.CreateCommand();

                    tableCommand.CommandText = "INSERT INTO drinking_water(Date, Quantity) VALUES(DATE('now'),1)";

                    // Don't return any values, not querying any values
                    tableCommand.ExecuteNonQuery();

                    connection.Close();
                }
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
}