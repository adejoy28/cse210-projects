
class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();
        tracker.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        tracker.AddGoal(new EternalGoal("Read Scriptures", 0));
        tracker.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));

        tracker.RecordGoalEvent("Run a Marathon");
        tracker.RecordGoalEvent("Read Scriptures");
        tracker.RecordGoalEvent("Attend Temple");
        tracker.RecordGoalEvent("Attend Temple");

        tracker.DisplayGoals();

        tracker.SaveGoals("goals.dat");
        GoalTracker loadedTracker = GoalTracker.LoadGoals("goals.dat");
        loadedTracker.DisplayGoals();
    }
}
