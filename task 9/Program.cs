// Напишите программу которая на вход принимает трехзначное число и на выходе показывает последнюю его цифру.

int chislo(int X)
{
    int p = 0;
    p = X % 10;
    return p;
}

int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue); // Преобразование строки в целое число
    return value;
}
int value = Prompt("Введите число > ");
System.Console.WriteLine($"-> {chislo(value)}");