using System;

namespace Task_2_3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            double a = GetPositiveNumber("Введите сторону a внутреннего прямоугольника = ");
            double b = GetPositiveNumber("Введите сторону b внутреннего прямоугольника = ");
            double c = GetPositiveNumber("Введите сторону c внешнего прямоугольника = ");
            double d = GetPositiveNumber("Введите сторону d внешнего прямоугольника = ");

            if (CanFit(a, b, c, d))
            {
                Console.WriteLine("Да, прямоугольник помещается.");
            }
            else
            {
                Console.WriteLine("Нет, прямоугольник не помещается.");
            }
        }

        static double GetPositiveNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                {
                    return value;
                }
                Console.WriteLine("Нужно положительное число.");
            }
        }

        static bool CanFit(double a, double b, double c, double d)
        {
            bool straight = a <= c && b <= d;
            bool turned = a <= d && b <= c;
            return straight || turned;
        }
    }
}
