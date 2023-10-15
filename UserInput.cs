using EditTableOperations;

namespace UserInput;

public class ClassUserInput
{
    public void GetUserInput()
    {
        Console.Clear();
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

            Console.WriteLine("--------------------------------------------------");

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