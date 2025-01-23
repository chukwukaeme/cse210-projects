using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your guess should be between 0 to 11");
        Random random = new Random();
        int magicNumber = random .Next(1, 11);

        int guess = 0;

        while(guess != magicNumber)
        {
            Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber < guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed correctly");
            }
        }

    }
}