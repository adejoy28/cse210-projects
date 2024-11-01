using System;

class Program
{
    static void Main(string[] args)
    {
        // For Part 1 and 2: 
        // Ask the user to guess the magic number

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();

        // Set default toContinue to allow loop run
        string toContinue = "yes";

        // While loop runs till the user quits
        while (toContinue == "yes")
        {
            // To keep tracK of how manu guessed the user made
            int guessCount = 0;

            // Part 3: Generate random number from 1-100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // Set a default guessnumber to allow loop run
            int guessedNumber = -1;

            // while loop runs till the user guess the correct number
            while (magicNumber != guessedNumber)
            {

                Console.Write("What is the guess (1-100)? ");
                guessedNumber = int.Parse(Console.ReadLine());

                // Checl answer against magic number and display relative message while adding to the guess attempts
                if (magicNumber > guessedNumber)
                {
                    Console.WriteLine("Lower");
                    guessCount += 1;

                }
                else if (magicNumber < guessedNumber)
                {
                    Console.WriteLine("Higher");
                    guessCount += 1;
                }
                else
                {
                    guessCount += 1;
                    Console.WriteLine($"You guessed it! It took you {guessCount} guess!");
                }
            }

            // Ask if user wishes to continue
            Console.Write("Do you want to play again (yes/no)? ");
            toContinue = Console.ReadLine().ToLower();

            // Check for answer and display relative message
            if (toContinue == "yes")
            {
                Console.WriteLine("The game will restart!");
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}