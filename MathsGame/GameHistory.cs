using System;
using System.Collections.Generic;
using MathsGame.Models;

namespace MathsGame
{
    internal class GameHistory
    {
        static List<Game> games = new List<Game>();

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

        internal static void AddToHistory(int gameScore, GameType gameType, GameDifficulty difficulty)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Difficulty = difficulty,
                Type = gameType
            });
        }
    }
}
