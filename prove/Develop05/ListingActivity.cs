using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<string> _userList = new();
    public ListingActivity(string name, string description, int count) : base(name, description)
    {
        _count = count;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours ?");
        _prompts.Add("Who are people that you have helped this week ?");
        _prompts.Add("When have you felt the Holy Ghost this month ?");
        _prompts.Add("Who are some of your personal heroes ?");

    }
    public void Run()
    {
        Console.Clear();
        Console.Write($"Getting ready...");
        ShowSpinner(5);
        Console.Write("\n\n");

        Console.WriteLine("List as many responses you can to the following prompt:");
        int index = GetRandomPrompts();
        Console.WriteLine($"--- {_prompts[index]} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(6);
        Console.Write("\n");



        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (endTime > currentTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            GetListFromUser(userInput);

            currentTime = DateTime.Now;
        }
        Console.Clear();
        Console.WriteLine($"You listed {_userList.Count()} items");

        DisplayListToUser(index);

        DisplayEndingMessage();

    }
    public int GetRandomPrompts()
    {
        // Show random prompts
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count());

        return index;
    }
    public List<string> GetListFromUser(string userInput)
    {
        _userList.Add(userInput);
        return _userList;
    }

    public void DisplayListToUser(int index)
    {
        Console.WriteLine($"Here are your responses to: {_prompts[index]}");
        int i = 0;
        foreach (var list in _userList)
        {
            Console.WriteLine($"{i + 1}. {list}");
        }
        Console.Write("\nPress any key to return to menu");
        Console.ReadLine();
    }

}