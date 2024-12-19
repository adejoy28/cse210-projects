
public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isComplete;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string DisplayStatus();
    public int GetPoints() => points;
    public string GetName() => name;
    public bool IsComplete() => isComplete;
}
