//Supplies rsndom promptd whenever needed

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    // Constructor to initialize some prompts
    public PromptGenerator()
    {
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count); // Get a random index from the prompts list
        return _prompts[index]; // Return the random prompt
    }
}