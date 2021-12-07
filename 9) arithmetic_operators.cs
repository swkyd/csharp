using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pie = 10;

            // pie = pie + 1;      full version
            // pie += 1;          short version
            // pie ++;     use only to +1 or -1 

            // pie = pie - 1;
            // pie -= 1;
            // pie --;

            // pie = pie * 2;
            // pie *= 2;

            // pie = pie / 2;
            // pie /= 2;

            // remainder (%) - divides two numbers and returns the remainder
            // ex: 10 % 2 = 0; 10 % 3 = 1 
            int remainder = pie % 3; 

            Console.WriteLine(pie + " % 3 = " + remainder);

            // wait before closing
            Console.ReadKey();
        }
    }
}