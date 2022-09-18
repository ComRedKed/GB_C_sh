// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;

Console.WriteLine("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2 ? $"{number} -> {numberS[2]}" : $"{numberS} -> третьей цифры нет");
