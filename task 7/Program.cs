// Вычислить факториал числа

int Prompt(string message)
{
    Console.Write(message);                                              // Вывод приглашения
    // int strValue;                                                            // Объявление переменной для ввода строки
    string strValue = Console.ReadLine() ?? "0";                                       // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);                                            // Преобразование строки в целое число
    return value;
}

int Factorial(int value)
{
    int factorial = 1;
    for (int i = 1; i <= value; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

int value = Prompt("Введите число > ");
int factorial = 1;
if (value < 0)
{
    System.Console.WriteLine("Число должно быть больше нуля");
}
else
{
    for (int i = 1; i <= value; i++)
    {
        factorial = factorial * i;
    }
    System.Console.WriteLine($"Факториал {value} равен => {Factorial(value)}");
}


