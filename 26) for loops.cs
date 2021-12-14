using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop - repeats some code a FINITE amount of times

            /*
            for (int i = 0; i <= 10; i++) // count from 0 to 10
            {
                Console.WriteLine(i); // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            }
            */

            for (int i = 10; i >= 0; i--) // reverse from 10 to 0
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Happy New Year!!!"); // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 Happy New Year!!!


            // wait before closing
            Console.ReadKey();
        }
    }
}