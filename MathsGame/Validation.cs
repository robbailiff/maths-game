using System;
using System.Collections.Generic;
using System.Text;

namespace MathsGame
{
    class Validation
    {
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
    }
}
