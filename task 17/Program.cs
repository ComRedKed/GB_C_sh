// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

const int XCOORD = 0;
const int YCOORD = 1;

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] IncertCoords()
{
    int[] temp = new int[2];
    temp[XCOORD] = Prompt("Введите Х: ");
    temp[YCOORD] = Prompt("Введите Y: ");
    return temp;
}

double Lenght(int[] firstCoord, int[] secondCoord)
{
    return Math.Sqrt(Math.Pow(firstCoord[XCOORD] - secondCoord[YCOORD],2) + Math.Pow(firstCoord[YCOORD] - secondCoord[YCOORD],2));
}
int[] firstPoint = IncertCoords();
int[] secondPoint = IncertCoords();
Lenght(firstPoint, secondPoint);
System.Console.WriteLine($"Длина = {Lenght(firstPoint, secondPoint):f2}");
