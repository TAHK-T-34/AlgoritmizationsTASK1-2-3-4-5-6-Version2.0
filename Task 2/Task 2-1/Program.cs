using System;

namespace Task_2_1
{
    internal static class Program
    {
        /// <summary>
        /// Тип вычисляемой фигуры.
        /// </summary>
        enum Figure
        {
            Prism = 1,
            Pyramid = 2
        }

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
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

        /// <summary>
        /// Запрашивает у пользователя выбор фигуры.
        /// </summary>
        /// <returns>Выбранная фигура.</returns>
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

        /// <summary>
        /// Запрашивает число сторон основания.
        /// </summary>
        /// <returns>Число сторон, не меньшее 3.</returns>
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

        /// <summary>
        /// Запрашивает положительное вещественное число с проверкой ввода.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Положительное число.</returns>
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

        /// <summary>
        /// Вычисляет площадь боковой поверхности правильной призмы.
        /// </summary>
        /// <param name="sides">Число сторон основания.</param>
        /// <param name="side">Сторона основания.</param>
        /// <param name="height">Высота призмы.</param>
        /// <returns>Площадь боковой поверхности.</returns>
        static double GetPrismArea(int sides, double side, double height)
        {
            return sides * side * height;
        }

        /// <summary>
        /// Вычисляет площадь боковой поверхности правильной пирамиды.
        /// </summary>
        /// <param name="sides">Число сторон основания.</param>
        /// <param name="side">Сторона основания.</param>
        /// <param name="apothem">Апофема пирамиды.</param>
        /// <returns>Площадь боковой поверхности.</returns>
        static double GetPyramidArea(int sides, double side, double apothem)
        {
            return 0.5 * sides * side * apothem;
        }
    }
}
