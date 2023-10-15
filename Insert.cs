using Microsoft.Data.Sqlite;

namespace Insert;
public class InsertRecord
{
    public void InsertMethod()
    {
        string connectionString = @"Data Source=habit-Tracker2.db";

        string date = GetDateInput();
        int quantity = GetQuantityInput();

        Console.WriteLine("Insert Record switch case");
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var insertCommand = connection.CreateCommand();

            insertCommand.CommandText = $"INSERT INTO drinking_water(Date, Quantity) VALUES('{date}', {quantity})";

            // Don't return any values, not querying any values
            insertCommand.ExecuteNonQuery();

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