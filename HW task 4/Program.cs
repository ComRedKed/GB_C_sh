// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
using System.Collections.Generic;
using System.Linq;
 
class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Write number 1: ");
        // int n = int.Parse(Console.ReadLine());
        int m = 1;
        Console.Write("Введи число > ");
        int n = int.Parse(Console.ReadLine());
        for (int i = m; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}
