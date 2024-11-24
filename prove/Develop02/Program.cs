using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program");
        int choice = 0;

        Journal journal = new Journal();
        do
        {
            Entry anEntry = new Entry();

            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            // Console.WriteLine(choice);
            
            if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
            {
                if (choice == 1)
                {
                    PromptGenerator randomPrompts = new PromptGenerator();

                    // randomPrompts._prompts.Add("Who was the most interesting person I interacted with today?");
                    // randomPrompts._prompts.Add("If I had one thing I could do over today, what would it be?");
                    // randomPrompts._prompts.Add("What was the strongest emotion I felt today?");
                    // randomPrompts._prompts.Add("How did I see the hand of the Lord in my life today?");
                    // randomPrompts._prompts.Add("What was the best part of my day?");

                    anEntry._date = DateTime.Today.ToShortDateString();
                    anEntry._promptText = randomPrompts.GetRandomPrompt(); // assignvalue to anEntry attributes.
                    Console.WriteLine($"{anEntry._promptText}");
                    anEntry._entryText = Console.ReadLine();

                    journal.AddEntry(anEntry);

                }
                else if (choice == 2) // To display all entries
                {
                    journal.DisplayAll();
                }
                else if (choice == 3) // To load from file
                {
                    Console.Write("What is the name of the file? ");
                    string fileName = Console.ReadLine();

                    journal.LoadFromFile(fileName);
                }
                else if (choice == 4) // To save to file
                {
                    Console.WriteLine("What is the filename? ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                }
                else if (choice == 5) // To quit program
                {
                    Console.WriteLine("You've done well. Thank you!");
                }

            }
            else 
            {
                Console.WriteLine("Wrong Entry! Please try again!");
            }
        } while (choice != 5);

    }
}