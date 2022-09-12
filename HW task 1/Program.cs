// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int Prompt(string message)
{
    Console.Write(message);                                              // Вывод приглашения
    string strValue;                                                            // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";                                       // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);                                            // Преобразование строки в целое число
    return value;
}
int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");
if (firstValue > secondValue)
{
    System.Console.WriteLine($"а = {firstValue}; b = {secondValue} -> max = {firstValue}, min = {secondValue}");
}
else
{
    System.Console.WriteLine($"а = {firstValue}; b = {secondValue} -> max = {secondValue}, min = {firstValue}");
}

