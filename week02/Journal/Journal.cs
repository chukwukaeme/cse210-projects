//Stores a listof journal entries
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    
    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response); //create a new entry
        _entries.Add(newEntry); //To add it to the list
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        List<string> entryDataList
    }
    public void LoadFromFile(string file)
    {

    }
}