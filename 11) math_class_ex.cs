using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a C# program that will calculate the smaller and greater given number

            System.Console.WriteLine("First number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("\n");

            double max = Math.Max(first, second);
            Console.WriteLine("Greater number is: " + max);

            double min = Math.Min(first, second);
            Console.WriteLine("Smaller number is: " + min);

            // wait before closing
            Console.ReadKey();
        }
    }
}