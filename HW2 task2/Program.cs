// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
int num1 = num / 100;
int num3 = (num % 100) % 10;
System.Console.WriteLine($"{num} -> {num1}{num3}"); 
