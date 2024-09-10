using System;

namespace Task_2
{
    internal class Program
    {
        /// <summary>
        /// Отправная точка программы
        /// </summary>
        static void Main()
        {
            ReadInteger("X = ", out int x);
            ReadInteger("Y = ", out int y);

            float k = Expression(x, y);
            Console.WriteLine(string.Format("X = {0} Y = {0} К = {0:f6}", x, y, k));
        }

        /// <summary>
        /// Читает введённую строку с консоли и
        /// пытается спарсить её в целое число
        /// </summary>
        /// <param name="prompt">Приглашение к вводу</param>
        /// <param name="result">Результат парсинга</param>
        static void ReadInteger(string prompt, out int result)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                }
            }
        }

        /// <summary>
        /// f(x, y) = (138 * x + y) / (x - 24) - (x* y - 67) / (78 + x)
        /// </summary>
        static float Expression(float x, float y) =>
            (138 * x + y) / (x - 24) - (x * y - 67) / (78 + x);
    }
}