using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        // Writr a program that determines the letter grade for a course according to the following scal

        // As the user for their score
        Console.Write("What is your grade? ");
        string userScore = Console.ReadLine();
        int userScoreInt;
        // Convert string to Int
        bool IsuserScoreParsedIntoInt = Int32.TryParse(userScore, out userScoreInt);

        string letter = "";
        string gradeSign = "";

        
        // Test user score and assign the proper grade.
        if ( userScoreInt >= 90 ) 
        {
            letter = "A";
            // Console.WriteLine($"Your grade is A");

        } 
        else if ( userScoreInt >= 80 )
        {
            letter = "B";
            // Console.WriteLine($"Your grade is B");

        }
        else if ( userScoreInt >= 70 )
        {
            letter = "C";
            // Console.WriteLine($"Your grade is C");

        } 
        else if ( userScoreInt >= 60 )
        {
            letter = "D";
            // Console.WriteLine($"Your grade is D");

        }
        else if ( userScoreInt < 60 )
        {
            letter = "F";
            // Console.WriteLine($"Your grade is F");
        }


        // return a message
        string message;
        if (userScoreInt >= 70)
        {
            message = "Congratulations, you passed this class!";
            // Console.WriteLine("Congratulations, you passed this class!");
        } else 
        {
            message = "Ew! You can do better than this next time.";
            // Console.WriteLine("Ew! You can do better than this next time.");
        }

        // Get the last digit of the user score by MODULUS division and return {sign}
        int lastDigitOfUserScoreInt = userScoreInt % 10;
        
        if (lastDigitOfUserScoreInt >= 7)
        {
            gradeSign = "+";
        } else if (lastDigitOfUserScoreInt <= 3)
        {
            gradeSign = "-";
        }else {
            gradeSign = "";
        }

        // Display overall message to the user
        Console.WriteLine($"Your grade is {letter}{gradeSign}");
        Console.WriteLine(message);
    }
}