using System;
using System.Formats.Asn1;

public class Journal
{
    public List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public Journal(){}

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayEntry();
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the name of your file? ");
        string userInputFileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(userInputFileName))
        {
            foreach (JournalEntry journalEntry in _journalEntries)
            {
                writer.WriteLine($"{journalEntry._entryDate}; {journalEntry._journalPrompt}; {journalEntry._promptAnswer}");
            }
        }
    }

    // public void LoadJournal()
    // {
    //     Console.WriteLine("What is the name of your file? ");
    //     string userInput = Console.ReadLine();
    //     List<string> dataFromFile = new List<string>();

    //     using (StreamReader reader = new StreamReader(userInput))
    //     {
    //         string lineRead;
    //         while ((lineRead = reader.ReadLine()) != null)
    //         {
    //             dataFromFile.Add(lineRead); 
    //             foreach (string lineEntry in dataFromFile)
    //             {
    //                 string[] data = lineEntry.Split("; ");
    //                 JournalEntry newEntry = new JournalEntry();

    //                 newEntry._entryDate = data[0];
    //                 newEntry._journalPrompt = data[1];
    //                 newEntry._promptAnswer = data[2];

    //                 _journalEntries.Add(newEntry);
    //             }
    //         }
    //         Console.WriteLine("File loaded successfully!");
    //     }
//     }
// }

    public void LoadJournal()
    {
        Console.WriteLine("What is the name of your file? ");
        string userInput = Console.ReadLine();

        using (StreamReader reader = new StreamReader(userInput))
        {
            string lineRead;
            while ((lineRead = reader.ReadLine()) != null)
            {
                string[] data = lineRead.Split("; ");
                JournalEntry newEntry = new JournalEntry();

                newEntry._entryDate = data[0];
                newEntry._journalPrompt = data[1];
                newEntry._promptAnswer = data[2];

                _journalEntries.Add(newEntry);
            }
            Console.WriteLine("File loaded successfully!");
        }
    }
}