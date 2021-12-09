using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to find the largest of three numbers

            System.Console.Write("First number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Second number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Thrid number: ");
            double thrid = Convert.ToDouble(Console.ReadLine());

            /* my method: 

            if (first > second) {
                if (first > thrid) {
                    System.Console.WriteLine("The First is the greatest among three");
                } 
                else {

                }
            }
            if (second > first) {
                if (second > thrid) {
                    System.Console.WriteLine("The Second is the greatest among three");
                }
                else {

                }
            }
            if (thrid > first) {
                if (thrid > second) {
                    System.Console.WriteLine("The Third is the greatest among three");
                }
                else {

                }
            } */

            // easy method:
            
            if (first > second) {
                if (first > thrid) {
                    System.Console.WriteLine("The First is the greatest among three");
                }
                else {
                    System.Console.WriteLine("The Third is the greatest among three");
                }
            }
            else if (second > thrid) {
                System.Console.WriteLine("The second is the greatest among three");
            }
            else {
                System.Console.WriteLine("The Third is the greatest among three");
            }

            // wait before closing
            Console.ReadKey();
        }
    }
}