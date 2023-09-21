using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
      Random randomNumber = new Random();
      int magicNumber = randomNumber.Next(1,101);
      
      int guess = 0;
      
    while (guess != magicNumber)
    {

      Console.Write("What is the magic number? ");
      string userGuess = Console.ReadLine();
      guess = int.Parse(userGuess);

      if (guess == magicNumber)
      {
        Console.WriteLine("You guessed right");
      }
      
      else if (guess < magicNumber)
      {
        Console.WriteLine("Higher");  
      }
      else
      {
        Console.WriteLine("Lower");
      }
    }
    }
}

