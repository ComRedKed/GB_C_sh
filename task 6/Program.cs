// Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

double Prompt(string message)
{
    Console.Write(message);                                              // Вывод приглашения
    string strValue;                                                            // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";                                       // Вводим строку с консоли (с консоли можно ввести только строку)
    double value = int.Parse(strValue);                                            // Преобразование строки в целое число
    return value;
}

double value = Prompt("Введите число > ");
if (value == 0)
{
    System.Console.WriteLine("Делить на 0 нельзя");
}
else
{
    double result = 1 / value;
    System.Console.WriteLine($"{value} => {result}");
}

