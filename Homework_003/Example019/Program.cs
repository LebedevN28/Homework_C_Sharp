// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int originalNumber = number;
int reverse = 0;

while (number > 0)
{
    int lastDigit = number % 10;
    reverse = (reverse * 10) + lastDigit;
    number = number / 10;
}
if (originalNumber == reverse)
{
    Console.WriteLine($"да"!);
}
else
{
    Console.WriteLine($"нет"!);
}