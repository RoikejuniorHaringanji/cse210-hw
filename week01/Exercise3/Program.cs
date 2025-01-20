using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess My Number Game!");

        Random random = new Random();
        string playAgain;

        do
        {
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("\nI have picked a number between 1 and 100. Try to guess it!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");

                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it in {attempts} attempts.");
                }
            }

            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().Trim().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}