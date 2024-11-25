public class Scripture {
    Reference _reference = new Reference("John", 2,3);
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) 
    {

    }


    public void HideRanddomWords(int numberToHide)
    {
        Random rand = new Random();

        int numberOfWordsToHide = numberToHide;

        numberOfWordsToHide = rand.Next(1, _words.Count() + 1);
        
        for(int i = 0; i<numberOfWordsToHide; i++)
        {
            int indexToHide = rand.Next(_words.Count);
            // _words[indexToHide] = "****";
        }

        foreach (var word in _words)
        {
            Console.WriteLine(word);
        }
    }
    public string GetDisplayText()
    {
        return _reference.GetDisplayValue();  
    }
    public string IsCompletelyHidden()
    {
        return "i";
    }
}