//Represents a single jornal entry
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public Entry(string _promptTextromptText, string _entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }
    public Entry()
    {

    }
    public void Display()
    {
        Console.WriteLine($"[{_date}]");
        Console.WriteLine($"Prompt: {_promptText}")
        Console.WriteLine($"Entry: {_entryText}")
    }
    public override string ToString()
    {
        return $"{_date} | {_promptext} | {_entryText} ";
    }
}