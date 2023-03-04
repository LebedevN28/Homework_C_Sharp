// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] NewRandomArray(int row, int col)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AvgCol(int[,] mas)
{
    for(int i = 0; i< mas.GetLength(1); i++)
    {
        double avgcol = 0;
        for(int j = 0; j<mas.GetLength(0);j++)
        {
            avgcol+=mas[j,i];
        }
        avgcol/= mas.GetLength(0);
        Console.Write($"{avgcol:f2} ");
    }
}

int m = new Random().Next(3,5), n = new Random().Next(3,5);
int[,] array2D = NewRandomArray(m, n);
PrintArray2D(array2D);
Console.WriteLine("Средне арифметическое каждого столбца равна:");
AvgCol(array2D);