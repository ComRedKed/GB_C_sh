// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

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
int threeValue = Prompt("Введите третье число > ");
// int max = firstValue;
if (firstValue > secondValue && firstValue > threeValue)
{
    System.Console.WriteLine($"{firstValue},{secondValue}, {threeValue} -> {firstValue}");
}
if (secondValue > firstValue && secondValue > threeValue)
{
    System.Console.WriteLine($"{firstValue},{secondValue}, {threeValue} -> {secondValue}");
}
else
{
    System.Console.WriteLine($"{firstValue},{secondValue}, {threeValue} -> {threeValue}");
}