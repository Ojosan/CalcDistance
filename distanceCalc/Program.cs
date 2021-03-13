using System;

namespace distanceCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //color
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("enter a time (in hours): ");
            var time =Console.ReadLine();
            Console.Write("enter a speed (mph) : ");
            var speed = Console.ReadLine();

            //math
            double result = Convert.ToDouble(time) * Convert.ToDouble(speed);

            //new colors
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            //results
            Console.WriteLine("you will travel " + result + " miles");

            //close program
            Console.WriteLine("press any key to close.");
            Console.ReadKey();






        }
    }
}
