using System;
public class MainMenu
{
    private string options = "Please select one of the following choices (1-6):\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\nSelect a choice from the menu: ";
    public int GetOption()
    {
        int option;
        bool isValidInput = false;

        do
        {
            

            Console.Write(options);
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out option) && option >= 1 && option <= 6) //Checks for invalid input
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 7.");
            }
        } while (!isValidInput);

        return option;
    }
}
