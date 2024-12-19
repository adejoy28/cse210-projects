
public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int target;

    public ChecklistGoal(string name, int points, int target) : base(name, points)
    {
        this.target = target;
        this.timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        points += GetPoints();
        if (timesCompleted >= target)
        {
            points += 500; // Bonus points for completing the checklist
            isComplete = true;
        }
    }

    public override string DisplayStatus()
    {
        return isComplete ? $"[X] {name} (Completed {timesCompleted}/{target})" : $"[ ] {name} (Completed {timesCompleted}/{target})";
    }
}
