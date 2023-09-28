using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
               {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
       static void DisplayWelcome()
       {
            //Displays the message, "Welcome to the Program!"
            Console.WriteLine("Welcome to the program");
       }
 
       static string PromptUserName()
       {
            //Asks for and returns the user's name (as a string)
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
       }

       static int PromptUserNumber()
       {
            //Asks for and returns the user's favorite number (as an integer)
            Console.Write("What is your favorite number? ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
       }
       
       static int SquareNumber(int number)
       {
            //Accepts an integer as a parameter and returns that number squared (as an integer)
            return number * number;
       }
       
       static void DisplayResult(string userName, int squaredNumber)
       {
            Console.WriteLine($"Hello, {userName}!");
            Console.WriteLine($"Your favorite number squared is: {squaredNumber}");
       }
    }
}


// using System;

// class Program
// {
//     static void Main()
//     {
//         DisplayWelcome();
        
//         string userName = PromptUserName();
//         int userNumber = PromptUserNumber();
//         int squaredNumber = SquareNumber(userNumber);

//         DisplayResult(userName, squaredNumber);
//     }

//     static void DisplayWelcome()
//     {
//         Console.WriteLine("Welcome to the Program!");
//     }

//     static string PromptUserName()
//     {
//         Console.Write("Please enter your name: ");
//         return Console.ReadLine();
//     }

//     static int PromptUserNumber()
//     {
//         Console.Write("Please enter your favorite number: ");
//         string userInput = Console.ReadLine();

//         if (int.TryParse(userInput, out int number))
//         {
//             return number;
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Using 0 as the default number.");
//             return 0;
//         }
//     }

//     static int SquareNumber(int number)
//     {
//         return number * number;
//     }

//     static void DisplayResult(string userName, int squaredNumber)
//     {
//         Console.WriteLine($"Hello, {userName}!");
//         Console.WriteLine($"Your favorite number squared is: {squaredNumber}");
//     }
// }
