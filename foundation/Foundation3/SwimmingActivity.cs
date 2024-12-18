using System;

// Derived class for SwimmingActivity
class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        // return (GetDistance() / Minutes) * 60;
        return (GetDistance() / GetMinutes()) * 60;

    }

    public override double GetPace()
    {
        // return Minutes / GetDistance();
        return GetMinutes() / GetDistance();

    }
}