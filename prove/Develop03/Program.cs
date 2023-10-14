using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the reference of the scripture: ");
            string scriptureReference = Console.ReadLine();

            Console.Write("Enter the text of the scripture: ");
            string scriptureText = Console.ReadLine();

            Scripture scripture = new Scripture(scriptureReference, scriptureText);
            Word scriptureGame = new Word(scripture);
            scriptureGame.Play();
        }
            private static List<string> recordedReferences = new List<string>();
            private static List<string> recordedScriptures = new List<string>();

            private static void DisplayRecordedInputs()
            {
                    Console.WriteLine("Recorded Inputs:");
                    for (int i = 0; i < recordedReferences.Count; i++)
                {
                    Console.WriteLine($"Reference: {recordedReferences[i]}, Scripture: {recordedScriptures[i]}");
                }
            }
            
    }
}
