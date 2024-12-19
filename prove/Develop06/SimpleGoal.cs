
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override string DisplayStatus()
    {
        return isComplete ? $"[X] {name}" : $"[ ] {name}";
    }
}
