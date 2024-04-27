using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("Welcome to Guess My Number!");

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("You guessed it!");
                    guessedCorrectly = true;
                }
            } while (!guessedCorrectly);

            Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgain = Console.ReadLine();
            
            if (playAgain.ToLower() == "yes")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}