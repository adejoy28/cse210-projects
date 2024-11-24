public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() 
    {

        _top = 1;
        _bottom = 1;

        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
        // Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        // Console.WriteLine($"{_top}/{_bottom}");
    }



// Getters
    public int GetTopValue()
    {
        return _top;
    }
    public int GetBottomValue()
    {
        return _top;
    }

    // Setters
    public void SetTopValue(int topValue)
    {
        _top = topValue;
    }
    public void SetBottomValue(int bottomValue)
    {
        _bottom = bottomValue;
    }


    // Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}