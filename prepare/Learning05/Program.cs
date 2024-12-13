using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment ass = new Assignment("Joseph Smith", "Geometry");
        Console.WriteLine(ass.GetSummary());

        MathAssignment mathAss = new MathAssignment("Jane Jones", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAss.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}