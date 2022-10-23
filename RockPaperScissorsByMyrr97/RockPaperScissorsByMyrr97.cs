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

            Console.WriteLine("Do you want to play on Rock Paper Scissors" +
                "\n[Y]es" +
                "\n[N]o");
            ConsoleKey key;
            while ((key = Console.ReadKey().Key) != ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (key == ConsoleKey.N)
                {
                    Console.WriteLine("You are so boring :(");
                    Console.ResetColor();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid option...");
                }
                Console.ResetColor();
            }
            Console.WriteLine();

            string playerMove = String.Empty;
            int totalPlayerWins = 0;
            int totalPCWins = 0;
            int totalDrawGames = 0;
            while (true)
            {
                
                
                Console.ResetColor();
                Console.Write("Write how many rounds you want to play: ");
                int totalGames;
                if (int.TryParse(Console.ReadLine(), out totalGames))
                {
                    int playerWinMoves = 0;
                    int PCWinMoves = 0;
                    int drawMoves = 0;

                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Choose [r]ock, [p]aper, [s]cissors");
                        Console.ResetColor();
                        key = Console.ReadKey().Key;
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
                            playerWinMoves++;
                        }
                        else if ((playerMove == scissors && PCMove == rock) || (playerMove == rock && PCMove == paper)
                            || (playerMove == paper && PCMove == scissors))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Lose! :(");
                            PCWinMoves++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("This round was a draw. :)");
                            drawMoves++;
                        }

                        if (playerWinMoves == totalGames / 2 + 1 || PCWinMoves == totalGames / 2 + 1)
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\nTotal rounds: {drawMoves + PCWinMoves + playerWinMoves}\n" +
                        $"Player win rounds: {playerWinMoves}\n" +
                        $"PC win rounds: {PCWinMoves}\n" +
                        $"Draw rounds: {drawMoves}\n");

                    Console.ResetColor();
                    Console.WriteLine("Do you want another game?" +
                        "\n[Y]es" +
                        "\n[N]o");

                    totalPlayerWins += playerWinMoves;
                    totalPCWins += PCWinMoves;
                    totalDrawGames += drawMoves;

                    while ((key = Console.ReadKey().Key) != ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        if (key == ConsoleKey.N)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"\nTotal moves for all games: {totalDrawGames + totalPCWins + totalPlayerWins}\n" +
                                $"Total win rounds: {totalPlayerWins}\n" +
                                $"Total lost rounds: {totalPCWins}\n" +
                                $"Total Draw rounds: {totalDrawGames}");
                            Console.WriteLine("See you next time :)");
                            Console.ResetColor();
                            return;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option...");
                        }
                        Console.ResetColor();
                    }
                    Console.WriteLine();

                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Invalid input...");
                }
            }
        }
    }
}
