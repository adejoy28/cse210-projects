public class Entry
{
    static DateTime theCurrentTime = DateTime.Today; // = new Date();
    public string _date {get; set;} //= DateTime.Today.ToShortDateString();
    public string _promptText {get; set;}
    public string _entryText {get; set;}

    // public Entry()
    // {
    //     _date = "";
    //     _promptText = "";
    //     _entryText = "";
    // }

    public void Display()
    {
        // Date: 12/2/1134 - Prompt: _promptText;
        // _entryText
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"");
    }
}