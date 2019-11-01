using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 11);
            Console.WriteLine("Guess the number: ");
            int.TryParse(Console.ReadLine(), out int guessedNumber);
            
            string answerText = string.Format("you guessed {0}, the right answer {1}.", guessedNumber, randomNumber);
            
            if (guessedNumber == randomNumber) {
                answerText += " you guessed correctly!";
            } else if (guessedNumber > randomNumber) {
                answerText += " you guessed too high!";
            } else if (guessedNumber < randomNumber) {
                answerText += " you guessed too low!";
            }

            Console.WriteLine(answerText);
        }
    }
}
