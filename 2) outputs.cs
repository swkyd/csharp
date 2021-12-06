using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine - does hit the enter key after the end
            Console.WriteLine("Hello, Csharp!");

            // Console.Write - doesn't hit the enter key after the end
            Console.Write("Hello, Csharp!");

            // \n - new line: Hello,
                          //  Csharp!
            Console.WriteLine("\n Hello,\n Csharp!");

        
            // Wait before closing
            Console.ReadKey();
        }
    }
}