public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        name = "Breathing Activity";
    }

    public void Run()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);

        Console.Clear();
        Console.Write($"Getting ready...");
        ShowSpinner(5);
        Console.Write("\n\n");

        while (currentTime <= endTime)
        {
            Console.Write("Breathe in...");
            this.ShowCountDown(5);
            Thread.Sleep(1000);

            Console.Write("\nNow breathe out...");
            ShowCountDown(5);
            Thread.Sleep(1000);

            Console.Write("\n\n");

            currentTime = DateTime.Now;
        }

        // Console.WriteLine("Weldone");
        // ShowSpinner(5);
        DisplayEndingMessage();
    }
}