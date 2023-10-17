using System;

public class GoalCategory
{
    private string options = "Please select one of the following choices (1-4):\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\n    4. Return to previous menu\nWhich type of goal would you like to create? ";
 public int GetCategory()
    {
        int option;
        bool isValidInput = false;

        do
        {

            Console.Write(options);
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out option) && option >= 1 && option <= 5) //Checks for invalid input
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
            }
        } while (!isValidInput);

        return option;
    }


}