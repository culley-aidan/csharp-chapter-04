using System;
using System.Linq;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int[] randomNumbers = { RNG.Next(1, 5), RNG.Next(1, 5), RNG.Next(1, 5) };
            int[] guessedNumbers = new int[3];
            Console.Write("Guess the first number: ");
            int.TryParse(Console.ReadLine(), out guessedNumbers[0]);
            Console.Write("Guess the second number: ");
            int.TryParse(Console.ReadLine(), out guessedNumbers[1]);
            Console.Write("Guess the third number: ");
            int.TryParse(Console.ReadLine(), out guessedNumbers[2]);

            int award = 0;
            if (randomNumbers.SequenceEqual(guessedNumbers))
            {
                award = 10000;
            } else
            {
                int correctNumbers = guessedNumbers.Where(x => randomNumbers.Contains(x)).Count();
                award = correctNumbers switch
                {
                    1 => 10,
                    2 => 100,
                    3 => 1000,
                    _ => 0,
                };
            }
            Console.WriteLine("You got {0}", award.ToString("C"));
        }
    }
}