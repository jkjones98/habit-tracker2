using Microsoft.Data.Sqlite;
using UserInput;
using ViewAllRecords;

namespace DeleteRecord;

public class Delete
{
    ClassUserInput rtnToMainMenu = new ClassUserInput();
    ViewAll getRecords = new ViewAll();
    string connectionString = @"Data Source=habit-Tracker2.db";
    public void DelRecMethod()
    {
        Console.Clear();
        getRecords.ViewAllMethod();
        var recordId = GetNumberInput("\n\nPlease enter the ID of the record you would like to remove from the database\n\n");
    
        using(var connection = new SqliteConnection(connectionString))
        {
            // Open connection
            connection.Open();
            var tblCommand = connection.CreateCommand();
            tblCommand.CommandText = $"DELETE from drinking_water WHERE Id = '{recordId}'";

            int rowCount = tblCommand.ExecuteNonQuery();
            if(rowCount == 0)
            {
                Console.WriteLine($"\n\nRecord with Id {recordId} doesn't exist. \n\n");
                DelRecMethod();
            }

            connection.Close();
            
        }

        Console.WriteLine($"\n\nRecord with Id {recordId} has been deleted. \n\n");
        rtnToMainMenu.GetUserInput();
    }

    internal int GetNumberInput(string message)
    {
        Console.WriteLine(message);
        string recordId = Console.ReadLine();
        
        if(recordId == "0") rtnToMainMenu.GetUserInput();

        int cleanInput = Convert.ToInt32(recordId);

        return cleanInput;
    }
}