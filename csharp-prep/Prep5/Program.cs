using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Function name should use a title case e.g. NigeriaUniversalFuncitonForC#
        DisplayWelcome();

        string userName = PromptUserName();
        int userFavNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userFavNumber);
        DisplayResult(userName, squaredNumber);

    }
    // DisplayWelcome - Displays the message, "Welcome to the Program!" 

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your username: ");
        string name = Console.ReadLine();
        return name;
    }

    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        string userFavNumStr = Console.ReadLine();
        int favNum = int.Parse(userFavNumStr);
        return favNum;
    }

    // SquareNumber - Accepts an integer as a parameter and returns that number squared(as an integer)
    static int SquareNumber(int num)
    {
        int squaredNum = num * num;
        return squaredNum;
    }

    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }


}