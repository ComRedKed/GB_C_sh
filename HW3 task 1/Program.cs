// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1.
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число пятизначное число > ");
int num1 = number / 10000;
int num2 = number % 10000 / 1000;
int num3 = number % 1000 / 100;
int num4 = number % 100 / 10;
int num5 = number % 10;
if (number > 99999 || number <= 10000)
{
    System.Console.WriteLine("Это не пятизначное число");
}
else
{
    bool pal = (num1 == num5) && (num2 == num4);
    if (pal)
    {
        System.Console.WriteLine($"{number} -> да");
    }
    else
    {
        System.Console.WriteLine($"{number} -> нет");
    }
}

// 2.
Console.Write("Введите число пятизначное число > ");
string number = Console.ReadLine();
void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"{number} - да");
    }
    else Console.WriteLine($"{number} - нет");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Это не пятизначное число");


