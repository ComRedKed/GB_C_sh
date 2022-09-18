// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}

int firstNumber = Prompt("Введите первое число > ");
int secondNumber = Prompt("Введите второе число > ");

int value = firstNumber % secondNumber;
if (value != 0)
{
    System.Console.WriteLine($"{firstNumber}, {secondNumber} -> не кратно, остаток {value}");
}
else
{

    System.Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно"); 
}