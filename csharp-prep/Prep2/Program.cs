using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        // Writr a program that determines the letter grade for a course according to the following scal

        // As the user for their score
        Console.Write("What is your grade? ");
        int userScore = int.Parse(Console.ReadLine());


        string letter = "";
        string gradeSign = "";


        // Test user score and assign the proper grade.
        if (userScore >= 90)
        {
            letter = "A";
            // Console.WriteLine($"Your grade is A");

        }
        else if (userScore >= 80)
        {
            letter = "B";
            // Console.WriteLine($"Your grade is B");

        }
        else if (userScore >= 70)
        {
            letter = "C";
            // Console.WriteLine($"Your grade is C");

        }
        else if (userScore >= 60)
        {
            letter = "D";
            // Console.WriteLine($"Your grade is D");

        }
        else if (userScore < 60)
        {
            letter = "F";
            // Console.WriteLine($"Your grade is F");
        }


        // return a message
        string message;

        if (userScore >= 70)
        {
            message = "Congratulations, you passed this class!";
        }
        else
        {
            message = "Ew! You can do better than this next time.";
        }

        // Get the last digit of the user score by MODULUS division and return {sign}
        int lastDigitOfUserScore = userScore % 10;

        // Add + or - to the letter grade aside F and A+
        if (lastDigitOfUserScore >= 7 && userScore > 60 && userScore < 93)
        {
            gradeSign = "+";
        }
        else if (lastDigitOfUserScore <= 3 && userScore > 60 && userScore < 93)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        // Display overall message to the user
        Console.WriteLine($"Your grade is {letter}{gradeSign}");
        Console.WriteLine(message);
    }
}