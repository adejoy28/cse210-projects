using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

[Serializable] // This is optional for JSON serialization but good for clarity
public class GoalManager
{
    private List<Goal> goals;
    private int totalPoints;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                totalPoints += goal.GetPoints();
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    // Save the goals to a JSON file
    public void SaveGoals(string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var saveData = new SaveData(goals, totalPoints); // Wrap data into a single object
        File.WriteAllText(filePath, JsonSerializer.Serialize(saveData, options));
        Console.WriteLine("Goals have been saved successfully.");
    }

    // Load the goals from a JSON file
    public static GoalManager LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Returning a new GoalManager.");
            return new GoalManager();
        }

        var jsonData = File.ReadAllText(filePath);
        var saveData = JsonSerializer.Deserialize<SaveData>(jsonData);
        var manager = new GoalManager
        {
            goals = saveData.Goals,
            totalPoints = saveData.TotalPoints
        };
        Console.WriteLine("Goals have been loaded successfully.");
        return manager;
    }
}