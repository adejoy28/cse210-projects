using System;


int userInput = -1;

do
{
    Console.Clear();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Start breathing activity");
    Console.WriteLine("  2. Start reflecting activity");
    Console.WriteLine("  3. Start listing activity");
    Console.WriteLine("  4. Quit");
    Console.Write("Select a choice from the menu: ");
    userInput = Int32.Parse(Console.ReadLine());



    if (userInput == 1)
    {
        Console.Clear();

        BreathingActivity breathing = new("Breathing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.");

        breathing.DisplayStartingMessage();
        breathing.Run();

    }
    else if (userInput == 2)
    {
        Console.Clear();

        ReflectingActivity reflecting = new("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        reflecting.DisplayStartingMessage();
        reflecting.Run();


    }
    else if (userInput == 3)
    {
        Console.Clear();

        int count = 0;

        ListingActivity listing = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", count);

        listing.DisplayStartingMessage();
        listing.Run();

    }
    else if (userInput == 4)
    {
        Console.WriteLine("Thanks for using our mindfullness program.");
        Console.WriteLine("\nThe program will end now!");
    }


} while (userInput != 4);

