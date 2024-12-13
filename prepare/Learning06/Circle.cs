using System;
public class Circle : Shape
{
    private double _radius;
    public Circle(double radius, string color)
    {
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = 22 / 7 * _radius * _radius;
        return area;
    }
}