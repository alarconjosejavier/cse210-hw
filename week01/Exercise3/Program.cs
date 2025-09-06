using System;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
    int randomNumber = randomGenerator.Next(1, 100);
    Console.Write("What is your guess? ");
    int guessNumber = int.Parse(Console.ReadLine());

        while (randomNumber != guessNumber)
        {
            if (randomNumber> guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (randomNumber < guessNumber)
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
    }
}