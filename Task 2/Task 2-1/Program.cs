using System;

namespace Task_2_1
{
    internal static class Program
    {
        private const int MinSides = 3;
        private const double PyramidFactor = 0.5;
        private const string InputError = "Некорректный ввод.";

        /// <summary>
        /// Тип вычисляемой фигуры.
        /// </summary>
        enum Figure
        {
            /// <summary>
            /// Фигура не выбрана.
            /// </summary>
            None = 0,

            /// <summary>
            /// Правильная призма.
            /// </summary>
            Prism = 1,

            /// <summary>
            /// Правильная пирамида.
            /// </summary>
            Pyramid = 2
        }

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.WriteLine($"{(int)Figure.Prism} - боковая поверхность правильной призмы");
            Console.WriteLine($"{(int)Figure.Pyramid} - боковая поверхность правильной пирамиды");

            Figure figure = ParseFigure(ReadInput("Выберите вариант: "));
            if (figure == Figure.None)
            {
                Console.WriteLine(InputError);
                return;
            }

            if (!TryParseSides(ReadInput("Введите число сторон основания = "), out int sides))
            {
                Console.WriteLine(InputError);
                return;
            }

            if (!TryParsePositive(ReadInput("Введите сторону основания = "), out double side))
            {
                Console.WriteLine(InputError);
                return;
            }

            switch (figure)
            {
                case Figure.Prism:
                    if (!TryParsePositive(ReadInput("Введите высоту призмы = "), out double height))
                    {
                        Console.WriteLine(InputError);
                        return;
                    }
                    Console.WriteLine($"Площадь боковой поверхности = {GetPrismArea(sides, side, height)}");
                    break;
                case Figure.Pyramid:
                    if (!TryParsePositive(ReadInput("Введите апофему пирамиды = "), out double apothem))
                    {
                        Console.WriteLine(InputError);
                        return;
                    }
                    Console.WriteLine($"Площадь боковой поверхности = {GetPyramidArea(sides, side, apothem)}");
                    break;
            }
        }

        /// <summary>
        /// Считывает строку с клавиатуры.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Введённая строка.</returns>
        static string ReadInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Преобразует строку в выбранную фигуру.
        /// </summary>
        /// <param name="input">Введённая строка.</param>
        /// <returns>Выбранная фигура или Figure.None, если ввод некорректен.</returns>
        static Figure ParseFigure(string input)
        {
            if (int.TryParse(input, out int value) && Enum.IsDefined(typeof(Figure), value))
            {
                return (Figure)value;
            }
            return Figure.None;
        }

        /// <summary>
        /// Проверяет и преобразует строку в число сторон основания.
        /// </summary>
        /// <param name="input">Введённая строка.</param>
        /// <param name="sides">Число сторон основания.</param>
        /// <returns>true, если число корректно.</returns>
        static bool TryParseSides(string input, out int sides)
        {
            return int.TryParse(input, out sides) && sides >= MinSides;
        }

        /// <summary>
        /// Проверяет и преобразует строку в положительное вещественное число.
        /// </summary>
        /// <param name="input">Введённая строка.</param>
        /// <param name="value">Полученное число.</param>
        /// <returns>true, если число корректно и положительно.</returns>
        static bool TryParsePositive(string input, out double value)
        {
            return double.TryParse(input, out value) && value > 0;
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
            return PyramidFactor * sides * side * apothem;
        }
    }
}
