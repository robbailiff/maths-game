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

            var difficulty = Helpers.ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, (9 * (int) difficulty));
                secondNumber = random.Next(1, (9 * (int) difficulty));

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Addition, difficulty);

            Console.WriteLine($"\nGame over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            var difficulty = Helpers.ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, (9 * (int)difficulty));
                secondNumber = random.Next(1, (9 * (int)difficulty));

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Subtraction, difficulty);

            Console.WriteLine($"\nGame over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            var difficulty = Helpers.ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, (9 * (int)difficulty));
                secondNumber = random.Next(1, (9 * (int)difficulty));

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Multiplication, difficulty);

            Console.WriteLine($"\nGame over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal void DivisionGame(string message)
        {
            int score = 0;

            var difficulty = Helpers.ChooseDifficulty();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers(difficulty);
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Division, difficulty);

            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }
}
