// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int Akker(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return Akker(m - 1, 1);
    }
    return Akker(m - 1, Akker(m, n -1));
}
Console.WriteLine(Akker(m,n));