// Факториал

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int factorial = Prompt("Введите число для вычесления его факториала > ");
int FactorialCalc(int nunber)

{
    int fact = 1;

    for (int i = 1; i <= nunber; i++)
    {
        fact = fact * i;
    }
    return fact;
}
System.Console.WriteLine(FactorialCalc(factorial));