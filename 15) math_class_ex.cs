using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program that find a hypotenuse of a right triangle:

            System.Console.Write("Input a: ");
                double a = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Input b: ");
                double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));  // √a^2 + b^2

            System.Console.WriteLine("Hypotenuse: " + c);

            // wait before closing
            Console.ReadKey();
        }
    }
}