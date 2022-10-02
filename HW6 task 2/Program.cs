// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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
(double, double) LinearFunction(double k1, double k2, double b1, double b2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * x) + b1;
    return (x, y);
}
void Check(double k1, double k2, double b1, double b2)
{
    if (k1 == k2 && b1 != b2) System.Console.WriteLine("Линии паралельны");
    else if (k1 == k2 && b1 == b2) System.Console.WriteLine("Линии совпадают");
    else System.Console.WriteLine($"Линии пересекаются в точке {LinearFunction(k1, k2, b1, b2)}");
}
double b1 = Prompt("введите b1 > ");
double k1 = Prompt("введите k1 > ");
double b2 = Prompt("введите b2 > ");
double k2 = Prompt("введите k2 > ");
Check(k1, k2, b1, b2);