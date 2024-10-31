using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user their lastname
        Console.Write("What is your lastname? ");
        string lastName = Console.ReadLine();
        
        // Ask the user their firstname
        Console.Write("What is your firstname? ");
        string firstName = Console.ReadLine();
 
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}