using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Prompt prompt = new Prompt();
        Journal myJournal = new Journal();

        while (choice <= 4)
        {
            choice = GetOption(); //Calls the GetOption() function and stores its return value in the choice variable

            switch (choice)
            {
                // Write
                case 1:
                    string promptPick = prompt.GetRandomPromt();
                    JournalEntry jentry = new JournalEntry();
                    jentry._entryDate = GetEntryDate();
                    jentry._journalPrompt = promptPick;

                    Console.WriteLine(promptPick);
                    string promptAnswer = Console.ReadLine();
                    jentry._promptAnswer = promptAnswer;
                    myJournal._journalEntries.Add(jentry);
                    break;
                // Display Journal Entries
                case 2:
                    myJournal.DisplayJournal();
                    break;
                // Save Journal
                case 3:
                    myJournal.SaveJournal();
                    break;
                // Load Journal
                case 4:
                    myJournal.LoadJournal();
                    break;
                // Quit program
                case 5:
                Console.WriteLine("Program quit successfully. Thank you!.");
                    break;
                default:
                    Console.WriteLine($"Invalid option");
                    break;
            }
        }
    }

    // static int GetOption() //Displays the option menu
    // {
    //     string options = "Please select one of the following choices: \n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nWhat would you like to do? ";

    //     Console.Write(options);

    //     string userInput = Console.ReadLine();
    //     return int.Parse(userInput);
    // }

static int GetOption()
{
    int option;
    bool isValidInput = false;

    do
    {
        string options = "Please select one of the following choices (1-5):\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nWhat would you like to do? ";

        Console.Write(options);
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out option) && option >= 1 && option <= 5) //Checks for invalid input
        {
            isValidInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        }
    } while (!isValidInput);

    return option;
}

    static string GetEntryDate()
    {
        DateTime timeNow = DateTime.Now;
        return timeNow.ToString();
    }
}