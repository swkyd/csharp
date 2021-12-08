using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program that prompts the user for 2 integers and displays a random   // number on the screen between those values. 

            System.Console.WriteLine("First integer: ");
            int first = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Second integer: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            int rand = random.Next(first, second);

            System.Console.WriteLine("Random integer between " + first + " & " + second + " is: " + rand);

            // wait before closing
            Console.ReadKey();
        }
    }
}