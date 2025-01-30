//Represents a single jornal entry
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Constructor that accepts all three parameters (date, prompt, entryText)
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // New constructor that only accepts promptText and entryText, sets date to current date
    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");  // Set the current date
        _promptText = promptText;
        _entryText = entryText;
    }

    // Display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}