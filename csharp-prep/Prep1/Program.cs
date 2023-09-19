using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string LastName = Console.ReadLine();
        string FirstName = Console.ReadLine();
        Console.WriteLine($"{LastName},{FirstName} {LastName}");
    }
}