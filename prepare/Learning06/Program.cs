using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Shape> shapes = new();
        // Shape shape = new();
        // shape.SetColor("red");
        // Console.WriteLine($"Color of the Shape is: {shape.GetColor()}");

        Square square1 = new(4.0, "Green");
        shapes.Add(square1);
        // Console.WriteLine($"The Area of the {square1.GetColor()} Square: {square1.GetArea()}");

        Rectangle rect1 = new(4.0, 2.0, "Yellow");
        shapes.Add(rect1);
        // Console.WriteLine($"The Area of the {rect1.GetColor()} Rectangle: {rect1.GetArea()}");

        Circle circle1 = new(4.0, "Blue");
        shapes.Add(circle1);
        // Console.WriteLine($"The Area of the {circle1.GetColor()} Circle: {circle1.GetArea()}");

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The Area of the {shape.GetColor()} Shape is: {shape.GetArea()}");
        }
    }
}