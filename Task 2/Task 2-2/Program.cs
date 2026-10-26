using System;

namespace Task_2_2
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            int a = GetInt("Введите a = ");
            int b = GetInt("Введите b = ");
            int c = GetInt("Введите c = ");

            Console.WriteLine($"Наименьшее число: {GetMin(a, b, c)}");
        }

        /// <summary>
        /// Запрашивает целое число с проверкой ввода.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Введённое целое число.</returns>
        static int GetInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                Console.WriteLine("Некорректный ввод, введите целое число.");
            }
        }

        /// <summary>
        /// Находит наименьшее из трёх чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        /// <returns>Наименьшее число.</returns>
        static int GetMin(int a, int b, int c)
        {
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;
        }
    }
}
