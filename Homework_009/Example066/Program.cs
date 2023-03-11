// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNtoM(int m, int n)
{
    if (m==n) return m;
    return SumNtoM(m+1,n)+m;
}

Console.Write("Введите M: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNtoM(x, y));