using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        // // for one verse
        // Reference reference = new Reference("John", 3, 16);
        // string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        
        // for more than one lines
        Reference reference = new Reference("John", 3, 16, 17);
        string text = "16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        Scripture scripture = new Scripture(reference, text);
        do
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Word word = new Word(text);
            word.Hide();
            scripture.HideRanddomWords(3);
            input = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();

                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("All words are hidden. Program will now end.");
                break;
            }
        } while (input != "quit");
    }
}