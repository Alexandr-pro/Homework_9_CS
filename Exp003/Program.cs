// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

// M = 28; N = 7 -> 7


using System;

namespace Test
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            else
            {
                var min = Math.Min(a, b);
                var max = Math.Max(a, b);
                return GCD(max - min, min);
            }
        }
        static void Main(string[] args)
        {
            int N, M;
            Console.Write("Программа для нахождения наибольшего общего делителя (НОД)\n" +
                "Введите целочисленное значение M: ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целочисленное значение N: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Наибольший общий делитель: " + GCD(M, N));
        }
    }
}
