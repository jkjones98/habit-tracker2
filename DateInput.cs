using Microsoft.Win32.SafeHandles;
using UserInput;

namespace DateInput;

public class UserDateInput
{
    ClassUserInput rtnToMainMenu = new ClassUserInput();
    internal string getDate(string message)
    {
        Console.WriteLine(message);

        string dateInput = Console.ReadLine();

        if(dateInput == "0") rtnToMainMenu.GetUserInput();

        return dateInput;
    }
}