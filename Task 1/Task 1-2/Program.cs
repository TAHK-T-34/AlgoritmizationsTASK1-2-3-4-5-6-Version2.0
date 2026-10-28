using System;

namespace Task_1_2
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            double a = GetNumber("Введите сторону a = ");
            double b = GetNumber("Введите сторону b = ");
            double c = GetNumber("Введите сторону c = ");

            Console.WriteLine($"Объём параллелепипеда V = {GetVolume(a, b, c)}");
            Console.WriteLine($"Площадь полной поверхности S = {GetSurfaceArea(a, b, c)}");
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
        /// Вычисляет объём прямоугольного параллелепипеда.
        /// </summary>
        /// <param name="a">Длина.</param>
        /// <param name="b">Ширина.</param>
        /// <param name="c">Высота.</param>
        /// <returns>Объём.</returns>
        static double GetVolume(double a, double b, double c)
        {
            return a * b * c;
        }

        /// <summary>
        /// Вычисляет площадь полной поверхности прямоугольного параллелепипеда.
        /// </summary>
        /// <param name="a">Длина.</param>
        /// <param name="b">Ширина.</param>
        /// <param name="c">Высота.</param>
        /// <returns>Площадь полной поверхности.</returns>
        static double GetSurfaceArea(double a, double b, double c)
        {
            return 2 * (a * b + b * c + a * c);
        }
    }
}
