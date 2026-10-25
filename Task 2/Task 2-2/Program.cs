using System;

namespace Task_2_2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int a = GetInt("Введите a = ");
            int b = GetInt("Введите b = ");
            int c = GetInt("Введите c = ");

            Console.WriteLine($"Наименьшее число: {GetMin(a, b, c)}");
        }

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
