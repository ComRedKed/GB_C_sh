// Вычислить число фибоначи

int Prompt(string message)
{
    Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно перевестив целое число");
}

int value = Prompt("Введите число больше 0 > ");
if (value < 0)
{
    System.Console.WriteLine("Число должно быть больше 0");
}
else
{
    System.Console.WriteLine($"Номер числа последовательности Фибонначи {value} равен значению числа - > {Fibbonachi(value)}");
}

int Fibbonachi(int value)
{
    int fibbonachi = 0;
    int tempVar1 = 0;
    int tempVar2 = 1;
    for (int i = 0; i <= value; i++)
    {
        fibbonachi = tempVar1 + tempVar2;
        tempVar1 = tempVar2;
        tempVar2 = fibbonachi;
    }
    return tempVar1;
}

