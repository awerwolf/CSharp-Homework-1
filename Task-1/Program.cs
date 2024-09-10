using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1. Первая программа.");

            // значение префиксного выражения:
            int r;
            r = 6;
            Console.WriteLine(" значение префиксного выражения:");
            Console.WriteLine(" ++r = " + (++r));

            // значение постфиксного выражения:
            int t = 6;
            Console.WriteLine(" значение постфиксного выражения:");
            Console.WriteLine("до ++ t = " + (t++) + " после ++ t=" + t);
        }
    }
}
