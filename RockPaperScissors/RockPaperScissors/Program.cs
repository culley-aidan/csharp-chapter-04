using System;

namespace RockPaperScissors
{
    class Program
    {
        enum RPS { p, s, r }
        enum rockPS { PAPER, SCISSORS, ROCK }
        static void Main(string[] args)
        {
            Random RNG = new Random();
            RPS playerOne = (RPS)RNG.Next(0, 3), playerTwo;
            Console.Write("Pick a character (r,p,s): ");
            if (!Enum.TryParse(Console.ReadLine(), out playerTwo)) {
                playerTwo = (RPS)RNG.Next(0, 3);
            }
            string finalMessage = string.Format("The computer picked: {0}, you picked: {1}.", ((rockPS)playerOne).ToString(), ((rockPS)playerTwo).ToString());
            if (userWon(playerOne, playerTwo)) {
                finalMessage += " You won!";
            } else {
                finalMessage += " You didn't win!";
            }
            Console.WriteLine(finalMessage);
        }

        static bool userWon(RPS playerOne, RPS playerTwo)
        {
            if (playerOne == RPS.r && playerTwo == RPS.p) {
                return true;
            } else if ((playerOne == RPS.r && playerTwo == RPS.p) || playerOne == playerTwo) {
                return false;
            } else {
                return playerOne < playerTwo;
            }
        }
    }
}