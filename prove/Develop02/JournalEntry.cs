using System;

public class JournalEntry
{
   public string _entryDate = "";
   public string _journalPrompt = "";
   public string _promptAnswer = "";
   

   public JournalEntry(){}

   public void DisplayEntry()
   {
    Console.WriteLine($"Date: {_entryDate} - Prompt: {_journalPrompt}");
    Console.WriteLine($"{_promptAnswer}");
   } 
}