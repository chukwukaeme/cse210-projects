// ChecklistGoal - Requires multiple completions
class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Progress: {_amountCompleted}/{_target} completed. You earned {_points} points.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal '{_shortName}' completed! Bonus {_bonus} points awarded!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailsString() => $"[{(_amountCompleted >= _target ? "X" : _amountCompleted.ToString())}/{_target}] {_shortName} - {_description}";
    public override string GetStringRepresentation() => $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
}