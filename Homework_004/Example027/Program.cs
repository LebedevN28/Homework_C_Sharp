// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int SumNum(int num)
{
    int result = 0;
    while (num != 0)
    {
        result+=num%10;
        num=num/10;
    }
    return result;
}

Console.Write($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {a} = {SumNum(a)}");