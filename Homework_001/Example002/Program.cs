// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine()!);
int max = a;

if (b > a)
{
    max = b;
    Console.WriteLine($"max = {max}");
}
else
    Console.WriteLine($"max = {max}");
