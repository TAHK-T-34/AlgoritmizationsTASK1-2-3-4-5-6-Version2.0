using System;

namespace Task_1_3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            double work = GetNumber("Введите работу A (Дж) = ");
            double voltage = GetNumber("Введите напряжение U (В) = ");
            double time = GetNumber("Введите время t (с) = ");

            double current = GetCurrent(work, voltage, time);

            Console.WriteLine($"Сила тока I = {current} А");
        }

        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }

        static double GetCurrent(double work, double voltage, double time)
        {
            return work / (voltage * time);
        }
    }
}
