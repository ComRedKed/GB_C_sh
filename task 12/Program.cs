// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число > ");
int a = int.Parse(Console.ReadLine()!);
bool remains = (a % 7 == 0) && (a % 23 == 0);
if (remains)
{
    Console.WriteLine($"{a} -> Да");
}
else
{
    Console.WriteLine($"{a} -> Нет");
}