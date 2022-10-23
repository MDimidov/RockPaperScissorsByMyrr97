using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissorsByMyrr97
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Rock Paper Scissors by Myrr97";

            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            string playerMove = String.Empty;
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine($"Choose [r]ock, [p]aper, [s]cissors");
                var key = Console.ReadKey().Key;
                Console.WriteLine();
                if (key == ConsoleKey.R)
                {
                    playerMove = rock;
                }
                else if (key == ConsoleKey.P)
                {
                    playerMove = paper;
                }
                else if (key == ConsoleKey.S)
                {
                    playerMove = scissors;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid input! Try again...");
                    continue;
                }

                Random random = new Random();
                int PCRandomNumber = random.Next(1, 4);

                string PCMove = String.Empty;
                if (PCRandomNumber == 1)
                {
                    PCMove = rock;
                }
                else if (PCRandomNumber == 2)
                {
                    PCMove = paper;
                }
                else
                {
                    PCMove = scissors;
                }

                if ((playerMove == rock && PCMove == scissors) || (playerMove == paper && PCMove == rock)
                    || (playerMove == scissors && PCMove == paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You Win! :D");
                }
                else if ((playerMove == scissors && PCMove == rock) || (playerMove == rock && PCMove == paper)
                    || (playerMove == paper && PCMove == scissors))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Lose! :(");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("This game was a draw. :)");
                }
            }
        }
    }
}
