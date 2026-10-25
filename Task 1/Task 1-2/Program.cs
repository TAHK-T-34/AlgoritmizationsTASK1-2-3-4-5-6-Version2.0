using System;

namespace Task_1_2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            double a = GetNumber("Введите сторону a = ");
            double b = GetNumber("Введите сторону b = ");
            double c = GetNumber("Введите сторону c = ");

            Console.WriteLine($"Объём параллелепипеда V = {GetVolume(a, b, c)}");
            Console.WriteLine($"Площадь полной поверхности S = {GetSurfaceArea(a, b, c)}");
        }

        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }

        static double GetVolume(double a, double b, double c)
        {
            return a * b * c;
        }

        static double GetSurfaceArea(double a, double b, double c)
        {
            return 2 * (a * b + b * c + a * c);
        }
    }
}
