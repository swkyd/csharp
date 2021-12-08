using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // random numbers

            Random rand = new Random();

            // random one number:
            int num = rand.Next(1, 7); // from 1 to 6
            
            System.Console.WriteLine(num);

            // random two (or more) numbers:
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10); // from 1 to 9
            
            System.Console.WriteLine(num1);
            System.Console.WriteLine(num2);

            // random decimal number
            double num3 = rand.NextDouble(); // use NextDouble for double

            System.Console.WriteLine(num3);

            // wait before closing
            Console.ReadKey();
        }
    }
}