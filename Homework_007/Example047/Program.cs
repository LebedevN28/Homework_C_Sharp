// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Создать двумерный массив вещественных чисел
double[,] GetArray(int row, int col, double minValue, double maxValue)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
    return array;
}
// Вывести массив на экран
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

// Запросить количество строк и столбцов массива
Console.Write("Введите количество стобцов - m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк - n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] myArray = GetArray(m, n, -9.9, 9.9);
PrintArray(myArray);
