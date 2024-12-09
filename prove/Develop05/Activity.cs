using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Write($"Welcome to the {_name} \n\n{_description}");
        Console.Write("How long, in seconds, would you like for your see");
        int timeDuration = Int32.Parse(Console.ReadLine());
        _duration=
    }
    public void DisplayEndingMessage() { }
    public void ShowSpinner() { }
    public void ShowCountDown(int seconds) { }
}