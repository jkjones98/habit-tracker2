using System;
using Microsoft.Data.Sqlite;
using EditTableOperations;

namespace habit_tracker2;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = @"Data Source=habit-Tracker2.db";

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var tableCommand = connection.CreateCommand();

            tableCommand.CommandText =
                @"CREATE TABLE IF NOT EXISTS drinking_water
                (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date TEXT,
                    Quantity INTEGER

                )
                ";

            // Don't return any values, not querying any values
            tableCommand.ExecuteNonQuery();

            connection.Close();

        }

        GetUserInput();
    }

    static void GetUserInput()
    {
        Operations editTable = new Operations();

        bool closeApp = false;
        
        while (closeApp == false)
        {
            Console.WriteLine("What would you like to add to the table?");
            Console.WriteLine("Enter 0 to Close Application");
            Console.WriteLine("Enter 1 to View All Records");
            Console.WriteLine("Enter 2 to Insert Record");
            Console.WriteLine("Enter 3 to Delete Record");
            Console.WriteLine("Enter 4 to Update Record ");

            string userInput = Console.ReadLine();

            int cleanUserInput;
            // Parse input to ensure that it is valid
            while (!int.TryParse(userInput, out cleanUserInput))
            {
                Console.WriteLine("Please enter a valid number!");
                userInput = Console.ReadLine();
            }

            // Check to see if the number is greater than 4(valid selection)
            if (cleanUserInput > 4)
            {
                while (cleanUserInput > 4)
                {
                    Console.WriteLine("Please choose an option between 0 and 4");
                }
            }
            else
            {
                editTable.EditTableSwitch(cleanUserInput);

            }

            if(cleanUserInput == 0)
                closeApp = true;
        }

        
        
    }
}
