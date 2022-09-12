// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int Prompt(string message)
{
    Console.Write(message);                                              // Вывод приглашения
    string strValue;                                                            // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";                                       // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);                                            // Преобразование строки в целое число
    return value;
}

int value = Prompt("Введите число > ");
if (value % 2 == 0)
{
    System.Console.WriteLine($"{value} -> да");
}
else
{
    System.Console.WriteLine($"{value} -> нет");
}

