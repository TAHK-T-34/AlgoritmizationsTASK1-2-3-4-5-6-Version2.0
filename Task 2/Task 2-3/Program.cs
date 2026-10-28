using System;

namespace Task_2_3
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
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
        /// Проверяет, помещается ли прямоугольник a x b в прямоугольник c x d
        /// при параллельных сторонах (обе ориентации).
        /// </summary>
        /// <param name="a">Сторона a.</param>
        /// <param name="b">Сторона b.</param>
        /// <param name="c">Сторона c.</param>
        /// <param name="d">Сторона d.</param>
        /// <returns>true, если помещается.</returns>
        static bool CanFit(double a, double b, double c, double d)
        {
            bool straight = a <= c && b <= d;
            bool turned = a <= d && b <= c;
            return straight || turned;
        }
    }
}
