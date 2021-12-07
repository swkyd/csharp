using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine - userinput

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your age? ");
            int age = Convert.ToInt32(Console.ReadLine()); // here we convert to Int, 
                                                           // because user will type age

            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("You are " + age + " years old!");

            // wait before closing
            Console.ReadKey();
        }
    }
}