using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // // To create a list, 

        // List<int> numbers = new List<int>();
        // List<string> strings = new List<string>();

        // numbers.Add(1);
        // numbers.Add(3);
        // numbers.Add(10);

        // strings.Add("John");
        // strings.Add("Peace");
        // strings.Add("Christopher");

        // Console.WriteLine($"{numbers[2]}, {strings[2]}");

        // Console.WriteLine($"{strings.Count}");

        // foreach (string word in strings)
        // {
        //     Console.WriteLine(word);
        // }

        List<int> ListOfNumbers = new List<int>();

        // Set default userInput to allow loop to run
        int userInput;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        // Use do while to adjust ask user to enter number
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());


            // Add number to the list if user inserted digits is not equal 0
            if (userInput != 0)
            {
                ListOfNumbers.Add(userInput);
            }

        } while (userInput != 0);


        int sum = 0;
        int maxNum = -1;
        int smallPositive = 1000000;


        foreach (int number in ListOfNumbers)
        {
            // Add each number in the list to get sum
            sum += number;

            // To check for the maximum number in the list
            if (number > maxNum)
            {
                maxNum = number;
            }

            // To get the smallest positive number in the list
            if (number < smallPositive && number > 0)
            {
                smallPositive = number;
            }


        }


        decimal count = ListOfNumbers.Count();
        // Console.WriteLine(count);
        // decimal avgNum = 0M;
        // avgNum = (sum / ListOfNumbers.Count);

        double avgNum = ListOfNumbers.Average();


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avgNum}");
        Console.WriteLine($"The largest number is: {maxNum}");
        Console.WriteLine($"The smallest positive number is: {smallPositive}");
        // Console


        // To sort the data
        ListOfNumbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int number in ListOfNumbers)
        {
            Console.WriteLine(number);
        }















    }
}