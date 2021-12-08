using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a C# program that will calculate Pow, Sqrt, Abs... of given number

            System.Console.WriteLine("Input a number: ");
                double numb = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");

            // Original
            System.Console.WriteLine("Original: " + numb);

            // Pow
            double pow = Math.Pow(numb, 2);
                System.Console.WriteLine("Pow: " + numb + " (^2) = " + pow);

            // Sqrt
            double sqrt = Math.Sqrt(numb);
                System.Console.WriteLine("Sqrt: √" + numb + " = " + sqrt);

            // Abs
            double abs = Math.Abs(numb);
                System.Console.WriteLine("Abs: " + abs);

            // Round
            double round = Math.Round(numb);
                System.Console.WriteLine("Round: " + round);

            // Ceiling
            double ceiling = Math.Ceiling(numb);
                System.Console.WriteLine("Ceiling: " + ceiling);

            // Floor
            double floor = Math.Floor(numb);
                System.Console.WriteLine("Floor: " + floor);

            // wait before closing
            Console.ReadKey();
        }
    }
}