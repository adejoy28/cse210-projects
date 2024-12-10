using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public List<int> showedIndices = new();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");


        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        Console.Clear();
        Console.Write($"Getting ready...");
        ShowSpinner(3);
        Console.Write("\n\n");

        DisplayPrompt();
        Thread.Sleep(1000);

        DisplayQuestions();
        Thread.Sleep(1000);

        DisplayEndingMessage();

    }

    public void GetRandomPrompts()
    {
        // Show random prompts
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count());
        Console.WriteLine($"    -- {_prompts[index]} ");
        // Console.WriteLine("Random questions comes up here");
    }

    public void GetRandomQuestions()
    {
        // Show random questions
        Random randomQuestion = new Random();
        // Console.WriteLine("Random Prompts comes up here");
        // int index = -1;

        /*int*/

        int index = randomQuestion.Next(_questions.Count());
        while (showedIndices.Contains(index))
        {
            index = randomQuestion.Next(_questions.Count());
        }
        Console.Write($"> {_questions[index]} ");
        showedIndices.Add(index);
        while (showedIndices.Count() == _questions.Count())
        {
            Console.WriteLine("You exhausted all the reflection questions. Kindly end now");
            break;
            // showedIndices.Clear();
        }
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        // Random prompts comes up here
        // --Think of a time when you have something difficult
        GetRandomPrompts();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }
    public void DisplayQuestions()
    {
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        while (endTime > currentTime)
        {
            GetRandomQuestions();
            ShowSpinner(5);

            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
    }
}