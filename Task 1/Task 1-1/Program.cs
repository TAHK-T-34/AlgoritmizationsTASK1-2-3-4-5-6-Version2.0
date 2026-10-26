using System;

namespace Task_1_1
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 3;
            const double c = 1;

            double x = GetNumber("Введите x = ");
            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}; y = {y}");
        }

        /// <summary>
        /// Получает число, введённое с клавиатуры.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Введённое число.</returns>
        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }

        /// <summary>
        /// Вычисляет значение функции y.
        /// </summary>
        /// <param name="a">Константа a.</param>
        /// <param name="b">Константа b.</param>
        /// <param name="c">Константа c.</param>
        /// <param name="x">Переменная x.</param>
        /// <returns>Значение функции.</returns>
        static double GetResult(double a, double b, double c, double x)
        {
            return (5.0 / 4.0 * a * Math.Log(Math.Abs(x * x + 1)) + b) /
                   (c * Math.Abs(x) + Math.Sqrt(x * x + 4));
        }
    }
}
