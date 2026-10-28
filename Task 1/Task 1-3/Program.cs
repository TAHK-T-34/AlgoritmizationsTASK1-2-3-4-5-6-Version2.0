using System;

namespace Task_1_3
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            double work = GetNumber("Введите работу A (Дж) = ");
            double voltage = GetNumber("Введите напряжение U (В) = ");
            double time = GetNumber("Введите время t (с) = ");

            double current = GetCurrent(work, voltage, time);

            Console.WriteLine($"Сила тока I = {current} А");
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
        /// Вычисляет силу тока по работе, напряжению и времени.
        /// </summary>
        /// <param name="work">Работа тока.</param>
        /// <param name="voltage">Напряжение.</param>
        /// <param name="time">Время.</param>
        /// <returns>Сила тока.</returns>
        static double GetCurrent(double work, double voltage, double time)
        {
            return work / (voltage * time);
        }
    }
}
