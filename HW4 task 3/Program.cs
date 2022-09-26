// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

const int NEGATIVE_VALUE = -1;
const int POSITIVE_VALUE = 1;

int Prompt(string message)
{
Console.Write(message);
bool isDigit = int.TryParse(Console.ReadLine(), out int number);
if (isDigit){
return number;
}
throw new Exception("Вы ввели не число");
}

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
Random rnd = new Random();
int[] answer = new int[length];
for (int i = 0; i < answer.Length; i++)
{
answer[i] = rnd.Next(minRandom, maxRandom + 1);
}
return answer;
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i]+ "\t");
}
System.Console.WriteLine();
}

const int MIN_ELEMENTS = -9;
const int MAX_ELEMENTS = 9;

int length = Prompt("Введите длину массива >");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
