using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = randomGenerator.Next(1, 101);
        int guessCount = 0;
        string answer = "yes";
        
        while (answer == "yes")
        {
            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount ++;
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($" \nYou guessed it!\nNumber of guesses: {guessCount}\n");
                    Console.Write("Do you want to play again? ");
                    answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        number = randomGenerator.Next(1, 101);
                        guess = randomGenerator.Next(1, 101);
                    }
                    else
                    {
                        Console.WriteLine("Thank you for playing!");
                        break;
                    }
                }
            }
        }
    }
}