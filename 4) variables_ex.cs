using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a C# program that takes the radius of a circle as input and calculate the perimeter and area of the circle:
            double rad = 12;
            
            // perimeter of circle: per = 2 * p * rad
            double per = 2 * 3.14159 * rad;

            // area of circle: area = p * (rad * rad)
            double area = 3.14159 * rad * rad;

            Console.WriteLine("Perimeter of circle with " + rad + " radius is: " + per);

            Console.Write("Area of circle with " + rad + " radius is: " + area);

            // Wait before closing
            Console.ReadKey();
        }
    }
}