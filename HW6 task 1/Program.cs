// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    bool count = int.TryParse(Console.ReadLine(), out int number);
    if (count)
    {
        return number;
    }
    throw new Exception("Это не число!");
}

int[] InputArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент массива -> ");
        // System.Console.Write($"Введите {i + 1}-й элемент массива -> ");
        // array[i] = int.Parse(Console.ReadLine() ?? "0");
        System.Console.WriteLine();
    }
    return array;
}

int PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void OutputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

void Chek(int count)
{
    if (count > 0)
    {
        int[] array = InputArray(count);
        OutputArray(array);
        System.Console.WriteLine();
        System.Console.WriteLine($"Количество чисел больше 0 -> {PositiveNumber(array)}");
    }
    else
    {
        System.Console.WriteLine("Введено отрицательное число");
    }
}

int count = Prompt("Введите размер масива -> ");
Chek(count);