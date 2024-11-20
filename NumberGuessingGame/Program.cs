using System;
using System.Collections.Generic;

class GuessNumber
{
    private int hiddenNumber;
    private List<int> guesses;

    public GuessNumber()
    {
        hiddenNumber = new Random().Next(1, 101);
        guesses = new List<int>();
    }

    public void Play()
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Let's guess the hidden number between 1 and 100.");

        while (true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Please enter a number within the range of 1 to 100..");
                continue;
            }

            if (guesses.Contains(guess))
            {
                Console.WriteLine("You've already tried that number!");
                continue;
            }

            guesses.Add(guess);

            if (guess < hiddenNumber)
            {
                Console.WriteLine("Your guess is Too low!");
            }
            else if (guess > hiddenNumber)
            {
                Console.WriteLine("Your guess is Too high!");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the correct number: {hiddenNumber}");
                Console.WriteLine($"You guessed it in {guesses.Count} attempts.");
                break;
            }
        }

        DisplayHistory();
    }
    private void DisplayHistory()
    {
        Console.WriteLine("\nYour Guess History:");
        foreach (var guess in guesses)
        {
            Console.WriteLine($"Guess: {guess}");
        }
    }

    public static void Main(string[] args)
    {
        GuessNumber game = new GuessNumber();
        game.Play();
    }
}