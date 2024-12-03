public class Scripture
{
    private Reference _reference; // = new Reference("John", 2,3);
    private List<Word> _words; // = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRanddomWords(int numberToHide)
    {
        Random rand = new Random();

        int numberOfWordsToHide = numberToHide;

        numberOfWordsToHide = rand.Next(1, _words.Count() + 1);
        List<Word> wordsToHide = _words.Where(word => !word.IsHidden()).OrderBy(_ => rand.Next()).Take(numberToHide).ToList();

        foreach (Word word in wordsToHide)
        {
            word.Hide();
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayValue()}\n{scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}