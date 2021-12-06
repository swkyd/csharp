using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants - it describes an entity that cannot be changed at program runtime
            const double pi = 3.14159;

            // pi = 420; we can't change the pi, because use const on 10 line. 

            Console.WriteLine(pi);

            // wait before closing
            Console.ReadKey();
        }
    }
}