using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        2

        int guess = -1;
        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }

}