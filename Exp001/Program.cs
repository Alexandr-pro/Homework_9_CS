// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8


using System;

namespace Test
{
    internal class Program
    {
        static void FindNumbers(int current, int max)
        {
            if (current > max)
                return;
            if (current > 0 && current % 2 == 0)
                Console.Write(current + " ");
            FindNumbers(current + 1, max);
        }
        static void Main(string[] args)
        {
            int N, M;
            Console.Write("Программа для нахождения чётных натуральных чисел в заданном промежутке(включительно)\n" +
                "Введите целочисленное значение M (минимальное): ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целочисленное значение N (максимальное): ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Чётные натуральные числа в заданном промежутке: ");
            FindNumbers(M, N);
        }
    }
}
