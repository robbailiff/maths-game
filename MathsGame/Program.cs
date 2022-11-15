using System;

namespace MathsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            var date = DateTime.UtcNow;

            string name = Validation.GetName();

            menu.ShowMenu(name, date);

            

           

        }
    }
}
