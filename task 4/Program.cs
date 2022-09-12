// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

int Prompt(string message)
{
    Console.Write(message);                                              // Вывод приглашения
    string strValue;                                                            // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";                                       // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);                                            // Преобразование строки в целое число
    return value;
}

int value = Prompt("Введите число > ");
for(int index = - value; index < value+1; index++)
{
    System.Console.WriteLine($"{index},");
}


