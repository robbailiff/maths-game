using System;

namespace MathsGame
{
    class Menu
    {
        GameEngine gameEngine = new GameEngine();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math's game.\n");
            Console.WriteLine("Press any key to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                    V - View Previous Games
                    A - Addition
                    S - Subtraction
                    M - Multiplication
                    D - Division
                    Q - Quit the program");
                Console.WriteLine("--------------------------------------------------------");

                string gameSelected = Console.ReadLine().ToLower().Trim();

                switch (gameSelected)
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye. Thanks for playing");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Type any key to continue");
                        Console.ReadLine();
                        break;
                }
            } while (isGameOn);
        }

    }
}
