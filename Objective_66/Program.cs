// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int Sum(int m, int n)
{
    if(n == m)
    {
        return m;
    }
    return n + Sum(m, n-1);
}
Console.WriteLine(Sum(m,n));