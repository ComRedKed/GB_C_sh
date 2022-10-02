// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] ReplaceRows(int[,] arr)
// {
//     int tmp = 0;
//     int lastpos = arr.GetLength(0) - 1;
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         tmp = arr[0, i];
//         arr[0, i] = arr[lastpos, i];
//         arr[lastpos, i] = tmp;
//     }
//     return arr;
// }

// int rows = Prompt("Кол-во строк: ");
// int cols = Prompt("Кол-во столбцов: ");
// int[,] myArray = GenerateArray(rows, cols, 5, 10);
// PrintArray(myArray);
// myArray = ReplaceRows(myArray);
// PrintArray(myArray);

int[,] TransposeArray(int[,] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            tmp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = tmp;
        }
    }
    return arr;
}

int[,] myArray = GenerateArray(4, 4, 1, 5);
PrintArray(myArray);
myArray = TransposeArray(myArray);
PrintArray(myArray);