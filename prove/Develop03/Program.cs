using System;

class Program
{
    static void Main(string[] args)
    {   
        string input = "";
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(new Reference("John",1,4), text);
         do
         {
            Console.Clear();
            
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter Key to continue or type 'quit' to finish");


            scripture.HideRanddomWords(3);
            // Console.WriteLine(scripture.GetDisplayText());
            // Word word1 = new Word();
            // word1.Hide();

            input = Console.ReadLine();
         } while (input != "quit");
    }
}