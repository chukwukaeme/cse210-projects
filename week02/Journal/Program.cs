using System;

class Program
{
    static void Main(string[] args)
    {
              // Create instances of the classes
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Display the main menu
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new journal entry
                    Console.Clear();
                    string prompt = promptGenerator.GetRandomPrompt(); // Get a random prompt
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    // Add the entry to the journal
                    journal.AddEntry(prompt, response);
                    Console.WriteLine("Entry added successfully!");
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "2":
                    // Display all journal entries
                    Console.Clear();
                    journal.DisplayAll();
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "3":
                    // Save journal to file
                    Console.Clear();
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved successfully!");
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "4":
                    // Load journal from file
                    Console.Clear();
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded successfully!");
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "5":
                    // Exit the program
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    Console.WriteLine("Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }

    }
}