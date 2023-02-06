// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome(14212)); // Нет
        Console.WriteLine(IsPalindrome(12821)); // Да
        Console.WriteLine(IsPalindrome(23432)); // Да
    }

    static bool IsPalindrome(int num)
    {
        string numString = num.ToString();
        int length = numString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numString[i] != numString[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}