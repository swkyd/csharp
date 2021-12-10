using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("First integer: ");
                double first = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Second integer: ");
                double second = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("\n");

            System.Console.WriteLine("Here are the options: ");
            System.Console.WriteLine("1. Plus");
            System.Console.WriteLine("2. Minus");
            System.Console.WriteLine("3. Multiple");
            System.Console.WriteLine("4. Divide");
            System.Console.WriteLine("5. Exit");

            System.Console.WriteLine("\n");

            System.Console.Write("Your choice: ");
                double choice = Convert.ToDouble(Console.ReadLine());

            if (choice == 1) {
                double plus = first + second;
                System.Console.WriteLine(first + " + " + second + " = " + plus); 
            }
                else if (choice == 2) {
                    double minus = first - second;
                    System.Console.WriteLine(first + " - " + second + " = " + minus); 
                }
                    else if (choice == 3) {
                        double multiple = first * second;
                        System.Console.WriteLine(first + " * " + second + " = " + multiple);     
                    }
                        else if (choice == 4) {
                            double divide = first / second;
                            System.Console.WriteLine(first + " / " + second + " = " + divide);
                        }
                            else {
                                return;
                            }

            // wait before closing
            Console.ReadKey();
        }
    }
}