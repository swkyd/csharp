using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators - can be used to check if more than 1 condition is true/false

            // && (and) - if both of them true
            // || (or) - if one of them true

            Console.Write("Temperature (C): ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("Warm!");
            }
                else if (temp <= -50 || temp >= 50)
                {
                    Console.WriteLine("Don't go outside!");
                }

            // wait before closing
            Console.ReadKey();
        }
    }
}