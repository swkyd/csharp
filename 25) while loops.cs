using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop - repeats some code while some condition remains true

            string name = "";

            while (name == "") // force to input something
            {
                 Console.WriteLine("Enter your name: ");
                 name = Console.ReadLine();
            }

            Console.WriteLine("Hello, " + name);

            // wait before closing
            Console.ReadKey();
        }
    }
}