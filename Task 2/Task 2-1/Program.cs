using System;

namespace Task_2_1
{
    internal static class Program
    {
        enum Figure
        {
            Prism = 1,
            Pyramid = 2
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 - боковая поверхность правильной призмы");
            Console.WriteLine("2 - боковая поверхность правильной пирамиды");

            Figure figure = GetFigure();
            int sides = GetSides();
            double side = GetPositiveNumber("Введите сторону основания = ");

            switch (figure)
            {
                case Figure.Prism:
                    double height = GetPositiveNumber("Введите высоту призмы = ");
                    Console.WriteLine($"Площадь боковой поверхности = {GetPrismArea(sides, side, height)}");
                    break;
                case Figure.Pyramid:
                    double apothem = GetPositiveNumber("Введите апофему пирамиды = ");
                    Console.WriteLine($"Площадь боковой поверхности = {GetPyramidArea(sides, side, apothem)}");
                    break;
            }
        }

        static Figure GetFigure()
        {
            while (true)
            {
                Console.Write("Выберите вариант (1 или 2): ");
                if (int.TryParse(Console.ReadLine(), out int value) && Enum.IsDefined(typeof(Figure), value))
                {
                    return (Figure)value;
                }
                Console.WriteLine("Некорректный выбор.");
            }
        }

        static int GetSides()
        {
            while (true)
            {
                Console.Write("Введите число сторон основания = ");
                if (int.TryParse(Console.ReadLine(), out int value) && value >= 3)
                {
                    return value;
                }
                Console.WriteLine("Нужно целое число не меньше 3.");
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

        static double GetPrismArea(int sides, double side, double height)
        {
            return sides * side * height;
        }

        static double GetPyramidArea(int sides, double side, double apothem)
        {
            return 0.5 * sides * side * apothem;
        }
    }
}
