public class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        ShowSpinner(3);
        
        List<string> responses = new List<string>();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Enter an item: ");
            responses.Add(Console.ReadLine());
            elapsed += 3;
        }
        
        Console.WriteLine($"You listed {responses.Count} items.");
    }
}
