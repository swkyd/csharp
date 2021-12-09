using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program to check whether a given number is even or odd

            System.Console.Write("Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int rem = num % 2;
            string result = (rem == 0) ? num + " is an even" : num + " is odd";

            System.Console.WriteLine(result);

            // wait before closing
            Console.ReadKey();
        }
    }
}