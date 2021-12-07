using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a C# program to calculate given marks

            Console.WriteLine("Marks in Math: ");
                double math = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Marks in Phy: ");
                double phy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Marks in Chem: ");
                double chem = Convert.ToDouble(Console.ReadLine());

            double all = math + phy + chem;

            Console.WriteLine("\n");

            Console.WriteLine("Math: " + math);
            Console.WriteLine("Phy: " + phy);
            Console.WriteLine("Chem: " + chem);

            Console.WriteLine("Total marks: " + all);

            // wait before closing
            Console.ReadKey();
        }
    }
}