using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 11);

        Console.Write("Pick a number between 1-11. What is your guess? ");
        string userInput = Console.ReadLine();

        int guess = int.Parse(userInput);

        while (guess != magic)
        {
            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");
    }
}
