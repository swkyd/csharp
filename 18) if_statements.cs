using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* if, else, else if, ternary operator
                less than (a < b)
                less than or equal to (a <= b)
                greater than (a > b)
                greater than or equal to (a >= b)
                equal to (a == b)
                not equal to (a != b)  */

            System.Console.Write("What time is it (1-24)?: ");
            double time = Convert.ToInt32(Console.ReadLine());

            /* typical example:

            if (time < 10) {
                System.Console.WriteLine("Good Morning!");
            }
            else if (time < 20) {
                System.Console.WriteLine("Good Day!");
            }
            else {
                System.Console.WriteLine("Good Night!");
            } */

            /* ternary operator:

            instead of writing:

            int time = 20;
            if (time < 18) {
                Console.WriteLine("Good Day!");
            }
            else {
                Console.WriteLine("Good Evening!");
            } 
            
            we can simply write: */

            string result = (time < 18) ? "Good Day!" : "Good Evening!";
            System.Console.WriteLine(result);

            // wait before closing
            Console.ReadKey();
        }
    }
}