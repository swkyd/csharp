using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            // string - for text (Hello)
            string name = "Dior";

            // bool - for true or false
            bool alive = true;

            // int - for whole numbers (1, 3, 5)
            int age = 21;

            // double - for decimal numbers (1.654, 54.568)
            double height = 175.5;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Alive? " + alive);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height (cm): " + height);

            Console.WriteLine("\n");

            // math example for int:

            // declaration
            int x;

             // initialization
            x = 45; 

            // declaration + initialization
            int y = 5; 

            int z;
            z = x / y;

            Console.Write(x + " / " + y + " = " + z);
        
            // Wait before closing
            Console.ReadKey();
        }
    }
}