using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting - converting a value to a different data type
            //                useful when we accept user input 

            double a = 3.14;
            int b = Convert.ToInt32(a); // converting to int

            int c = 421;
            double d = Convert.ToDouble(c) + 0.1; // converting to double

            int e = 321;
            string f = Convert.ToString(e); // converting to string

            string g = "$";
            char h = Convert.ToChar(g); // converting to char

            string i = "true";
            bool j = Convert.ToBoolean(i); // converting to bool

            Console.WriteLine(b); // console: 3
            Console.WriteLine(b.GetType()); // to display a data type. 
                                            // console: System.Int32
            Console.WriteLine(d); // console: 421.1
            Console.WriteLine(f); // console: 321
            Console.WriteLine(h); // console: $
            Console.WriteLine(j); // console: true

            // wait before closing
            Console.ReadKey();
        }
    }
}