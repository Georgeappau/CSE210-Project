using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string studentPercent = Console.ReadLine();
        int percent = int.Parse(studentPercent);

        string letter = "";
        
        if (percent >= 90)
        {
            //Console.WriteLine("A");
            letter = "A";
        }
        else if (percent >= 80)
        {
            //Console.WriteLine("B");
            letter = "B";
        }
        else if (percent >= 70)
        {
            //Console.WriteLine("C");
            letter = "C";
        }
        else if (percent >= 60)
        {
           // Console.WriteLine("D");
           letter = "D";
        }
        else 
        {
           // Console.WriteLine("F");
           letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations!! You have passed this class");
        }
        else 
        {
            Console.WriteLine("Don't give up. You will succeed next time.");
        }

    }
}