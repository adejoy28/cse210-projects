using System;

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<Activity> activities = new List<Activity>
        {
            new RunningActivity("05 May 2024", 90, 3.0),
            new CyclingActivity("06 May 2024", 60, 15.0),
            new SwimmingActivity("07 May 2024", 20, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
