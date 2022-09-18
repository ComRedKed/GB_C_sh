// Напишите программу, котрая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    Console.Write(message);                                              // Вывод приглашения
    string strValue;                                                            // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";                                       // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);                                            // Преобразование строки в целое число
    return value;
}

int days = Prompt("Введите день неделю > ");
 
if (days < 0 || days > 7)
{
    System.Console.WriteLine("Нет такого дня недели");
}
else
{
    if (days == 6 || days == 7)
    {
        System.Console.WriteLine($"{days} -> да");
    }
    else
    {
        System.Console.WriteLine($"{days} -> нет");
    }
}

