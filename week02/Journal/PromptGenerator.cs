//Supplies rsndom promptd whenever needed

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Random _random = new Random();
    public string GetRandomPrompt()
    //To clear this error, return somehting. eg empty string
    {
        int index = _random.Next(_prompts.counts);
        return _prompts [index];
    }
}