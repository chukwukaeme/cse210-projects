using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine();

    
    
        GoalManager manager = new GoalManager(); 
        manager.LoadGoals(); // Load saved goals if available

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Record Progress");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Save & Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.ListGoalDetails();
                    break;
                case "2":
                    CreateNewGoal(manager);
                    break;
                case "3":
                    RecordGoalProgress(manager);
                    break;
                case "4":
                    manager.DisplayPlayerInfo();
                    break;
                case "5":
                    manager.SaveGoals();
                    Console.WriteLine("Progress saved. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static void CreateNewGoal(GoalManager manager)
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal (One-time completion)");
        Console.WriteLine("2. Eternal Goal (Repeated forever)");
        Console.WriteLine("3. Checklist Goal (Complete multiple times)");
        Console.Write("Choice: ");
        
        string goalType = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target completion count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points upon full completion: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        manager.CreateGoal(newGoal);
        Console.WriteLine($"Goal '{name}' added successfully!");
    }

    static void RecordGoalProgress(GoalManager manager)
    {
        manager.ListGoalNames();
        Console.Write("\nEnter the goal number to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        manager.RecordEvent(index);
        Console.WriteLine("Goal progress recorded!");
    }
}
