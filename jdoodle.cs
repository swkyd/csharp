using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 * 2 / 2 = ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 20) {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("100 + 5 - 5 = ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 100) {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("75 - 25 / 5 = ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 70) {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine("Incorrect!");
            }
            
            Console.WriteLine("10 * 2 / 10 = ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 2) {
                Console.WriteLine("Correct!");
            }
            else {
                Console.WriteLine("Incorrect!");
            }
            // wait before closing
            Console.ReadKey();
        }
    }
}