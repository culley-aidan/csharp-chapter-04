using System;
using System.Linq;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int[] randomNumbers = { RNG.Next(1, 5), RNG.Next(1, 5), RNG.Next(1, 5) }, guessedNumbers = new int[3], rightNumbers;
            Console.Write("Guess the first number: ");
            int.TryParse(Console.ReadLine(), out guessedNumbers[0]);
            Console.Write("Guess the second number: ");
            int.TryParse(Console.ReadLine(), out guessedNumbers[1]);
            Console.Write("Guess the third number: ");
            int.TryParse(Console.ReadLine(), out guessedNumbers[2]);

            rightNumbers = guessedNumbers.Where(x => randomNumbers.Contains(x)).ToArray();

            int award;
            if (randomNumbers.SequenceEqual(guessedNumbers))
            {
                award = 10000;
            } else
            {
                int correctNumbers = rightNumbers.Count();
                award = correctNumbers switch
                {
                    1 => 10,
                    2 => 100,
                    3 => 1000,
                    _ => 0,
                };
            }
            Console.WriteLine();
            displayNumbers(randomNumbers, "Lottery Numbers: ");
            if (rightNumbers.Any())
            {
                displayNumbers(rightNumbers, "Correct Numbers: ");
            }
            Console.WriteLine(Environment.NewLine + "You got {0}", award.ToString("C"));
        }
        static void displayNumbers(int[] arr, string text)
        {
            Console.Write(text);
            foreach (int number in arr)
            {
                Console.Write("{0, -3}", number);
            }
            Console.WriteLine();
        }
    }
}