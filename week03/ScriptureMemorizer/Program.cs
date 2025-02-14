using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();
        
            // Define the scripture reference
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

            // Create the scripture object
            Scripture scripture = new Scripture(reference, scriptureText);

            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer!\n");

            // Main loop
            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                
                string userInput = Console.ReadLine()?.Trim().ToLower();

                if (userInput == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(2); // Hide 2 words at a time
            }

            // Final message when all words are hidden
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Well done!");
    }
}