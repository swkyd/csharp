using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
    
            System.Console.Write("Name: ");
                string name = Console.ReadLine();
            
            System.Console.Write("Surname: ");
                string surname = Console.ReadLine();
            
            string fullname = $"Full: {name} {surname}"; // string interpolation
                fullname = fullname.ToUpper(); // uppercase
            
            System.Console.WriteLine("\n");
            System.Console.WriteLine(fullname); // FULL: DIYORBEK TUKHTASINOV
            System.Console.WriteLine("Name's length: " + name.Length); // Name's length: 8
            System.Console.WriteLine("Name's first character: " + name[0]); // Name's first character: D
            
            // wait before closing
            Console.ReadKey();
        }
    }
}