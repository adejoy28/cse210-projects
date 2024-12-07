public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string arg)
    {
        _text = arg; //"For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
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
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "_______";
        }
        else
        {
            return _text;
        }

    }
}