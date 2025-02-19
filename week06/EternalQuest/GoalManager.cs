public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager() // ✅ Constructor (Matches Diagram)
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        DisplayPlayerInfo();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += 100;  // Example: Add points when a goal is completed
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            _goals = new List<Goal>(); // Reset list

            for (int i = 1; i < lines.Length; i++)
            {
                // TODO: Parse goals from file (implement later)
            }
        }
    }
}
