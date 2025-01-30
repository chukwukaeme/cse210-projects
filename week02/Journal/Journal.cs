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
        List<string> entryDataList = new List<string>();

        foreach (Entry entry in _entries)
        {
            entryDataList.Add($"{entry._date}|{entry._promptText}|{entry._entryText}"); //To format each entry   
        }
        File.WriteAllLines(file, entryDataList); // To write the list og entries to the file
        Console.WriteLine("Journal saved sucessfully using WriteAllLines.");
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            foreach(string line in File.ReadLines(file)) //To declare the type of line
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string entryText = parts[2];
                    _entries.Add(new Entry(date, prompt, entryText));
                }
            }
            Console.WriteLine("Jornal loaded successfully.");
        }
        else
        {
            /*If the file doesn't exist, display an error message*/
            Console.WriteLine("File is not found.");
        }
    }
}