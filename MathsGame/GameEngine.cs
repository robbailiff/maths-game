using System;
using MathsGame.Models;

namespace MathsGame
{
    class GameEngine
    {
        internal void AdditionGame(string message)
        {
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            var difficulty = ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, (9 * (int) difficulty));
                secondNumber = random.Next(1, (9 * (int) difficulty));

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Validation.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            GameHistory.AddToHistory(score, GameType.Addition, difficulty);

            Console.WriteLine($"\nGame over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            var difficulty = ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, (9 * (int)difficulty));
                secondNumber = random.Next(1, (9 * (int)difficulty));

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();

                result = Validation.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            GameHistory.AddToHistory(score, GameType.Subtraction, difficulty);

            Console.WriteLine($"\nGame over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            var difficulty = ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, (9 * (int)difficulty));
                secondNumber = random.Next(1, (9 * (int)difficulty));

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();

                result = Validation.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            GameHistory.AddToHistory(score, GameType.Multiplication, difficulty);

            Console.WriteLine($"\nGame over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal void DivisionGame(string message)
        {
            int score = 0;

            var difficulty = ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = GetDivisionNumbers(difficulty);
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();

                result = Validation.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
            }

            GameHistory.AddToHistory(score, GameType.Division, difficulty);

            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal int[] GetDivisionNumbers(GameDifficulty difficulty)
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

        internal GameDifficulty ChooseDifficulty()
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

            GameDifficulty difficulty = new GameDifficulty();

            switch (choice)
            {
                case "e":
                    difficulty = GameDifficulty.Easy;
                    break;
                case "n":
                    difficulty = GameDifficulty.Normal;
                    break;
                case "h":
                    difficulty = GameDifficulty.Hard;
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
