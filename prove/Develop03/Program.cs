using System;

class Program
{
    static void Main(string[] args)
    {   
        string input = "";
        Scripture scripture = new Scripture();
         do
         {
            Console.Clear();
            
            Console.WriteLine(scripture.GetDisplayText());
            Word word1 = new Word();
            word1.Hide();

            input = Console.ReadLine();
         } while (input != "quit");
    }
}