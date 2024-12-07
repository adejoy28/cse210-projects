public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        // _text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
        // Console.WriteLine(_isHidden);
    }
    public string GetDisplayText()
    {
        // return _text; //.Split();
        if (_isHidden == true)
        {
            return "_____";
        }
        else
        {
            return _text;
        }
    }
}