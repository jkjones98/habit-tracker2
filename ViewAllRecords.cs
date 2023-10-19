using Microsoft.Data.Sqlite;
using UserInput;
using System.Collections;
using System.Globalization;

namespace ViewAllRecords;

public class ViewAll
{
    string connectionString = @"Data Source=habit-Tracker2.db";
    public void ViewAllMethod()
    {
        
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var tableCommand = connection.CreateCommand();

            tableCommand.CommandText = "SELECT * FROM drinking_water";

            List<DrinkingWater> tableData = new();

            // Create sqlitedatareader
            SqliteDataReader reader = tableCommand.ExecuteReader();

            // If reader has rows run code inside if statement
            if(reader.HasRows)
            {
                // While reader is reading the rows run the below while loop
                while(reader.Read())
                {
                    // Add the data from table row 0, row 1, row 2 to the list 
                    tableData.Add(
                        new DrinkingWater
                        {
                            // number in brackets represents the index of the column id(0), date(1), quantity(2)
                            Id = reader.GetInt32(0),
                            Date = DateTime.ParseExact(reader.GetString(1), "dd-MM-yyyy", new CultureInfo("en-US")),
                            Quantity = reader.GetInt32(2)
                        }); ;
                    
                }
            }
            else
            {
                Console.WriteLine("No rows found");
            }
            connection.Close();

            Console.WriteLine("------------------------------------\n");
            foreach(var dw in tableData)
            {
                Console.WriteLine($"{dw.Id} - {dw.Date.ToString("dd-MM-yyyy")} - Quantity: {dw.Quantity}");
            }
            Console.WriteLine("------------------------------------\n");
        }
    }
}

public class DrinkingWater
{
    public int Id {get; set;}

    public DateTime Date {get; set;}

    public int Quantity {get; set;}
}