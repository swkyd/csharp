using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");

            Console.WriteLine("Simple Calculator!");

            Console.WriteLine("\n");

            Console.WriteLine("Here are the options: ");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Minus");
            Console.WriteLine("3. Multiple");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power");
            Console.WriteLine("6. Square root");
            Console.WriteLine("7. Absolute");
            Console.WriteLine("8. Round");
            Console.WriteLine("9. Ceiling");
            Console.WriteLine("10. Floor");
            Console.WriteLine("11. Minimum");
            Console.WriteLine("12. Maximum");
            Console.WriteLine("13. Exit");

            Console.WriteLine("\n");

            Console.Write("Choose (1-13): ");

            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose) {

                case 1: // 3 + 2 = 5
                    Console.WriteLine("\n");

                    Console.WriteLine("1. Plus: ");

                    Console.WriteLine("\n");

                    Console.Write("First number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                    double plus = num1 + num2;

                    Console.WriteLine("C: " + num1 + " + " + num2 + " = " + plus);
                break;

                case 2: // 3 - 2 = 1
                    Console.WriteLine("\n");

                    Console.WriteLine("2. Minus: ");

                    Console.WriteLine("\n");

                    Console.Write("First number: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Second number: ");
                        double num4 = Convert.ToDouble(Console.ReadLine());

                    double minus = num3 - num4;

                    Console.WriteLine("C: " + num3 + " - " + num4 + " = " + minus);
                break;

                case 3: // 3 * 2 = 6
                    Console.WriteLine("\n");

                    Console.WriteLine("3. Multiple: ");

                    Console.WriteLine("\n");

                    Console.Write("First number: ");
                        double num5 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Second number: ");
                        double num6 = Convert.ToDouble(Console.ReadLine());

                    double multiple = num5 * num6;

                    Console.WriteLine("C: " + num5 + " * " + num6 + " = " + multiple);
                break;

                case 4: // 3 / 2 = 1.5
                    Console.WriteLine("\n");

                    Console.WriteLine("4. Divide: ");

                    Console.WriteLine("\n");

                    Console.Write("First number: ");
                        double num7 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Second number: ");
                        double num8 = Convert.ToDouble(Console.ReadLine());

                    double divide = num7 / num8;

                    Console.WriteLine("C: " + num7 + " / " + num8 + " = " + divide);
                break;

                case 5: // 3 ^ 2 = 9
                    Console.WriteLine("\n");

                    Console.WriteLine("5. Power: ");

                    Console.WriteLine("\n");

                    Console.Write("Number: ");
                        double num9 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Power: ");
                        double power = Convert.ToDouble(Console.ReadLine());

                    double pow = Math.Pow(num9, power);

                    Console.WriteLine("C: " + num9 + " (^" + power + ") = " + pow);
                break;

                case 6: // √3 = 1.73
                    Console.WriteLine("\n");

                    Console.WriteLine("6. Square root: ");

                    Console.WriteLine("\n");

                    Console.Write("Number: ");
                        double num10 = Convert.ToDouble(Console.ReadLine());

                    double sqrt = Math.Sqrt(num10);

                    Console.WriteLine("C: √" + num10 + " = " + sqrt);
                break;

                case 7: // -3 = 3
                    Console.WriteLine("\n");

                    Console.WriteLine("7. Absolute: ");

                    Console.WriteLine("\n");

                    Console.Write("Number: ");
                        double num11 = Convert.ToDouble(Console.ReadLine());

                    double abs = Math.Abs(num11);

                    Console.WriteLine("C: Absolute: " + num11 + " -> " + abs);
                break;

                case 8: // 3.49 = 3; 3.51 = 4
                    Console.WriteLine("\n");

                    Console.WriteLine("8. Round: ");

                    Console.WriteLine("\n");

                    Console.Write("Number: ");
                        double num12 = Convert.ToDouble(Console.ReadLine());

                    double round = Math.Round(num12);

                    Console.WriteLine("C: Round: " + num12 + " -> " + round);
                break;

                case 9: // 3.49 = 4; -3.49 = -3
                    Console.WriteLine("\n");

                    Console.WriteLine("9. Ceiling: ");

                    Console.WriteLine("\n");

                    Console.Write("Number: ");
                        double num13 = Convert.ToDouble(Console.ReadLine());

                    double ceil = Math.Ceiling(num13);

                    Console.WriteLine("C: Ceiling: " + num13 + " -> " + ceil);
                break;

                case 10: // 3.49 = 3; -3.49 = -4
                    Console.WriteLine("\n");

                    Console.WriteLine("10. Floor: ");

                    Console.WriteLine("\n");

                    Console.Write("Number: ");
                        double num14 = Convert.ToDouble(Console.ReadLine());

                    double floor = Math.Floor(num14);

                    Console.WriteLine("C: Floor: " + num14 + " -> " + floor);
                break;

                case 11: // x = 3.99, y = 4, min = 3.99
                    Console.WriteLine("\n");

                    Console.WriteLine("11. Minimum: ");

                    Console.WriteLine("\n");

                    Console.Write("First number: ");
                        double num15 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Second number: ");
                        double num16 = Convert.ToDouble(Console.ReadLine());

                    double min = Math.Min(num15, num16);

                    Console.WriteLine("C: Minimum between " + num15 + " & " + num16 + " -> " + min);
                break;

                case 12: // x = 3.99, y = 4, max = 4
                    Console.WriteLine("\n");

                    Console.WriteLine("12. Maximum: ");

                    Console.WriteLine("\n");

                    Console.Write("First number: ");
                        double num17 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Second number: ");
                        double num18 = Convert.ToDouble(Console.ReadLine());

                    double max = Math.Max(num17, num18);

                    Console.WriteLine("C: Maximum between " + num17 + " & " + num18 + " -> " + max);
                break;

                case 13:
                    return;
            }

            // wait before closing
            Console.ReadKey();
        }
    }
}