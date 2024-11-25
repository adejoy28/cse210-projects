public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        _isHidden = false;
    }
    public void Hide()
    {
        // string[] splittedSentence = _text.Split();
        // if (_isHidden == false)
        // {
        // // foreach (var item in splittedSentence)
        // {


        //         char[] splittedText = item.ToCharArray();
        //         string newCharacter = 
        //         // Console.WriteLine(item.Count());//place(item, "-----"));
        //         Console.Write(item + " ");//place(item, "-----"));

        //     }
        // }
    }
    public void Show()
    {

    }
    public void IsHidden()
    {
        Console.WriteLine(_isHidden);
    }
    public string GetDisplayText()
    {
        return _text; //.Split();
    }
}