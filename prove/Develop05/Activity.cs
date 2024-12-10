using System;
using System.Runtime.Intrinsics.Arm;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        // _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Welcome to the {_name} \n\n{_description} \n");
        Console.Write("How long, in seconds, would you like for your session: ");
        int timeDuration = Int32.Parse(Console.ReadLine());
        _duration = timeDuration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        ShowSpinner(3);
        // Thread.Sleep(3000);
        // Console.WriteLine("These are the list of Activities you've completed");

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
        // Thread.Sleep(5000);

        Console.Write("\nPress any key to return to menu");
        Console.ReadLine();

        Console.Clear();

    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    // public void ShowSpinner(int seconds)
    // {
    //     List<string> spinner = new List<string>();
    //     spinner.Add("/");
    //     spinner.Add("-");
    //     spinner.Add("\\");
    //     spinner.Add("|");

    //     DateTime currentTime = DateTime.Now;
    //     DateTime endTime = currentTime.AddSeconds(seconds);

    //     while (endTime > currentTime)
    //     {
    //         foreach (var s in spinner)
    //         {
    //             Console.Write(s);
    //             Thread.Sleep(1000);
    // Console.Write("\b \b");
    //         }
    //         currentTime = DateTime.Now;
    //     }

    // }
    public void ShowCountDown(int seconds)
    {
        // Console.Write("Loading........");
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        // Console.Write("\b \b \b \b \b \b \b \b \b \b \b \b \b \b \b \b");
        // Console.Write("\b \b \b \b \b \b \b \b");
    }
}