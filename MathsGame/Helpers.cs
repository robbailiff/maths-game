using System;
using System.Collections.Generic;
using MathsGame.Models;

namespace MathsGame
{
    internal class Helpers
    {
        static List<Game> games = new List<Game>();

        internal static string GetName()
        {
            Console.WriteLine("Please type your name:");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static int[] GetDivisionNumbers(Difficulty difficulty)
        {
            var random = new Random();

            int firstNumber = random.Next(1, (99 * (int)difficulty));
            int secondNumber = random.Next(1, (99 * (int)difficulty));

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, (99 * (int)difficulty));
                secondNumber = random.Next(1, (99 * (int)difficulty));
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;

        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("----------------------------");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}({game.Difficulty}): {game.Score} pts");
            }

            Console.WriteLine("----------------------------\n");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType, Difficulty difficulty)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Difficulty = difficulty,
                Type = gameType
            });
        }

        internal static Difficulty ChooseDifficulty()
        {
            Console.WriteLine($@"Please choose the difficulty:
                E - Easy
                N - Normal
                H - Hard");
            string choice = Console.ReadLine();

            while (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Input can't be empty");
                choice = Console.ReadLine();
            }

            Difficulty difficulty = new Difficulty();

            switch (choice)
            {
                case "e":
                    difficulty = Difficulty.Easy;
                    break;
                case "n":
                    difficulty = Difficulty.Normal;
                    break;
                case "h":
                    difficulty = Difficulty.Hard;
                    break;
                default:
                    Console.WriteLine("Invalid input. Type any key to continue");
                    Console.ReadLine();
                    break;
            }

            return difficulty;
        }
    }
}
