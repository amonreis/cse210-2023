using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number for the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int userGuess = 9999;

        // Keep looping until the user guesses the magic number
        while (userGuess != magicNumber)
        {   
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            
            // If the user guess is higher or lower than the magic number 
            // display a message to help them guess it.
            if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            
            // Display a message if they guess the magic number
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}