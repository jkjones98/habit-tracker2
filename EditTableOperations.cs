using System.Collections;
using habit_tracker2;
using Insert;
using UpdateRecord;
using ViewAllRecords;
using DeleteRecord;
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
                Console.Clear();
                Console.WriteLine("Closing application");
                break;
            case 1:
                ViewAll viewRecords = new ViewAll();
                viewRecords.ViewAllMethod();
                break;
            case 2:
                InsertRecord insertRecord = new InsertRecord();
                insertRecord.InsertMethod();
                break;
            case 3:
                Delete deleteRecord = new Delete();
                deleteRecord.DelRecMethod();
                break;
            case 4:
                Update updateDatabase = new Update();
                updateDatabase.UpdateRecMethod();
                break;
            default:
                break;
        }
    }

}