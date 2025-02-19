public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter long, in seconds, would you like for your session?: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        RunActivity();
        DisplayEndingMessage();
    }

    protected abstract void RunActivity();

    private void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}