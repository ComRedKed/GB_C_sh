// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int num1 = new Random().Next(10, 10000);
Console.WriteLine(num1);
int max = 0;
while (num1 > 0)
{
    int temp = num1 % 10;
    if (max < temp)
        max = temp;
    num1 = num1 / 10;
}
Console.WriteLine(max);