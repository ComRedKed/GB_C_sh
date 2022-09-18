// Напишите программу, которая будет выдавать название дня недели по заданному.

int Prompt(string message)
{
    Console.Write(message);                                              // Вывод приглашения
    string strValue;                                                            // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";                                       // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);                                            // Преобразование строки в целое число
    return value;
}
// Первый вариант:
// string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// int value = Prompt("Введите день неделю > ");
// if (value < 0 || value > 7)
// {
//     System.Console.WriteLine("Нет такого дня недели");
// }
// else
// {
//     int daysValue = value - 1;
//     System.Console.WriteLine($"{value} => {days[daysValue]}");
// }

// Второй вариант:
int value = Prompt("Введите день недели > ");
if (value < 0 || value > 7)
{
    System.Console.WriteLine("Нет такого дня недели");
}
else
{
    if (value == 1)
    {
        System.Console.WriteLine("=> Понедельник");
    }
    if (value == 2)
    {
        System.Console.WriteLine("=> Вторник");
    }
    if (value == 3)
    {
        System.Console.WriteLine("=> Среда");
    }
    if (value == 4)
    {
        System.Console.WriteLine("=> Четверг");
    }
    if (value == 5)
    {
        System.Console.WriteLine("=> Пятница");
    }
    if (value == 6)
    {
        System.Console.WriteLine("=> Суббота");
    }
    if (value == 7)
    {
        System.Console.WriteLine("=> Воскресенье");
    }
}
