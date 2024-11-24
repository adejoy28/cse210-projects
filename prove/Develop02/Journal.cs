using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // {
    //     new Entry { _date = DateTime.Today.ToShortDateString(), _entryText = "", _promptText =""}
    // };

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry eachEntry in _entries)
        {
            eachEntry.Display();
        }
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file)) 
        {
            string jsonContent = File.ReadAllText(file);
            List<Entry> entriesFromLoadedFile = JsonSerializer.Deserialize<List<Entry>>(jsonContent);

            if (entriesFromLoadedFile != null)
            {
                _entries.AddRange(entriesFromLoadedFile);
            }
        }
        else {
            Console.WriteLine("File not found! Try again.");
        }

        // string[] lines = File.ReadAllLines(file);

        // foreach (string line in lines)
        // {
          
        // }
    }
    public void SaveToFile(string file)
    {   
        file = file+".json";
        string jsonContent = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true});
        
        File.WriteAllText(file, jsonContent);
        
        // File.WriteAllText(file, jsonContent);

        // using (StreamWriter outputFile = new StreamWriter(file))
        // {
        //     foreach (var eachEntry in _entries)
        //     {
        //         outputFile.WriteLine($"Date: {eachEntry._date} - Prompt: {eachEntry._promptText}");
        //         outputFile.WriteLine($"{eachEntry._entryText}");
        //         outputFile.WriteLine("");
        //     }
        // }
    }

}