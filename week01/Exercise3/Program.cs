using System;

class Program
{

    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("Guess a number! What is your guess? ");
        string guess = Console.ReadLine();
        int numberGuess = int.Parse(guess);

        int count = 1;


        if (number == numberGuess)
        {
            Console.WriteLine("Congratulations!!! You guessed it.");
        }
        else if (!(number == numberGuess))
        {
            if (number > numberGuess)
                {
                    Console.WriteLine("Guess higher.");
                }
                else
                {
                    Console.WriteLine("Guess lower.");
                }

            while (!(number == numberGuess))
            {
                Console.WriteLine("What is your guess? ");
                count = count +1;
                guess = Console.ReadLine();
                numberGuess = int.Parse(guess);

                if (number > numberGuess)
                {
                    Console.WriteLine("Guess higher.");
                }
                else if (number == numberGuess)
                {
                    Console.WriteLine("Congratulations!!! You guessed it.");
                }
                else if (number < numberGuess)
                {
                    Console.WriteLine("Guess lower.");
                }
            }

        Console.WriteLine($"Number of guesses: {count}");

        }

        
        
    }
}
