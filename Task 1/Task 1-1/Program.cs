using System;

namespace Task_1_1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 3;
            const double c = 1;

            double x = GetNumber("Введите x = ");
            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}; y = {y}");
        }

        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }

        static double GetResult(double a, double b, double c, double x)
        {
            return (5.0 / 4.0 * a * Math.Log(Math.Abs(x * x + 1)) + b) /
                   (c * Math.Abs(x) + Math.Sqrt(x * x + 4));
        }
    }
}
