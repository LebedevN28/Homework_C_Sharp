// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int cube = 1;
while (cube <= N)
{
    Console.Write($"{Math.Pow(cube, 3)}"!);
    if (cube != N)
    {
        Console.Write($", "!);
    }
    cube++;
}

