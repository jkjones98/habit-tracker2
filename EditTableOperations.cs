using System.Collections;
using habit_tracker2;
using Insert;
using UpdateRecord;
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

                Console.Clear();
                Console.WriteLine("Closing application");
                break;
            case 1:
                SqliteDataReader sqliteReader;
                Console.WriteLine("View all records switch case");
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    var tableCommand = connection.CreateCommand();

                    tableCommand.CommandText = "SELECT * FROM drinking_water";

                    sqliteReader = tableCommand.ExecuteReader();
                    while (sqliteReader.Read())
                    {
                        string dbReader = sqliteReader.GetString(0);
                        Console.WriteLine(dbReader);
                    }

                    // Get the number of columns in the database using the below
                    string numOfColumns = tableCommand.CommandText = "SELECT COUNT(*) FROM pragma_table_info('drinking_water')";

                    // Don't return any values, not querying any values
                    tableCommand.ExecuteNonQuery();
                    connection.Close();
                }
                break;
            case 2:
                InsertRecord insertRecord = new InsertRecord();
                insertRecord.InsertMethod();
                break;
            case 3:
                // Need to look up code to delete records, shouldn't be too hard
                // Will probably be like DELETE * FROM drinking_Water WHERE Id (x)
                Console.WriteLine("Delete record switch case");
                break;
            case 4:
                // Need to look up code for updating an existing record
                Console.WriteLine("Update record switch case");
                Update updateDatabase = new Update();
                updateDatabase.UpdateRecMethod();
                break;
            default:
                break;
        }
    }

}