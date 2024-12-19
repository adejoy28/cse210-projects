
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        points += 100; // Increment points for each event
    }

    public override string DisplayStatus()
    {
        return $"[ ] {name} (Eternal Goal)";
    }
}
