using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine("There is no new line after this statement");

        // int x;
        // x = 1234;

        // Console.Write(x);

        // // Trying Input function
        // Console.Write("What is your age? ");

        // int color = Console.ReadLine();

        // Console.WriteLine(color);

        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);

        // Console.WriteLine(number);

        // While loop
        // int i = 1;
        // while (i < 18)
        // {
        //     Console.WriteLine(i);
        //     i += 6;
        // }

        // do
        // {
        //     Console.WriteLine("He is a fine boy " + i);
        //     i++;
        // } while (i < 20);

        // for (int percent = 0; percent < 100; percent += 10)
        // {
        //     Console.WriteLine(percent);
        // }

        // Blind example
        Blind blind = new Blind();
        blind._width = 23;
        blind._height = 50;
        blind._color = "red";

        // Console.WriteLine($"{blind._width}m, {blind._height}m = {blind.GetArea()}m2");


        // Creating a class inside of a class
        House myHouse = new House();

        // myHouse._livingroom._width = 56;
        // myHouse._livingroom._height = 126;

        // Console.WriteLine(myHouse._livingroom.GetArea());
        // Console.WriteLine(myHouse._livingroom._color="blue");

        // Creating a custom list
        myHouse._blinds.Add(_kitchen);

        foreach (Blind item in myHouse._blinds)
        {
            Console.WriteLine(item.GetArea());
        }
    }
}