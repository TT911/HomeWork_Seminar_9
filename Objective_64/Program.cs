// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

int n = 1;

string Recurs (int m, int n)
{
    if(m == n)
    {
        return n.ToString();
    }
    return (m + " " + Recurs(m - 1, n));

}

Console.WriteLine(Recurs(m, n));