using System;
using System.Collections.Generic;
using System.Linq; // Add this for Sum method

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbersList = new List<int>();
        int numbers;

        do
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            numbers = int.Parse(userNumber);

            if (numbers != 0)
            {
                numbersList.Add(numbers);
            }
        }
        while (numbers != 0);

        int numSum = numbersList.Sum();
        Console.WriteLine($"The sum is: {numSum}");

        if (numbersList.Count > 0)
        {
            double average = (double)numSum / numbersList.Count; // Calculate average
            Console.WriteLine($"The average is: {average}");
        }
        else
        {
            Console.WriteLine("No numbers entered, average cannot be calculated.");
        }

        int max = int.MinValue;

        foreach (int number in numbersList)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is {max}");
    }
}
