// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}
// Решение без массива:
int num1 = Prompt("Введите первое число > ");
int num2 = Prompt("Введите второе число > ");
int num3 = Prompt("Введите третье число > ");
int num4 = Prompt("Введите четвертое число > ");
int num5 = Prompt("Введите пятое число > ");
int summ = num1 + num2 + num3 + num4 + num5;
double average = summ / 5;
Console.WriteLine($"{num1}, {num2}, {num4}, {num4}, {num5} -> сумма {summ}, среднее {average}");

// Решение с массивом:
int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Prompt($"Введите число {i + 1} > ");
}
int summ = Summ(numbers);
double average;

average = summ / numbers.Length;
Console.WriteLine($" -> сумма {summ}, среднее {average}");

int Summ(int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        summ += numbers[i];
    }
    return summ;
}
