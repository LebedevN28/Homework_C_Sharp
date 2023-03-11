// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MinSumRow(int[,] mas)
{
    int index = 0;
    int minSum = 1000000000;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sumRow+=mas[i,j];
        }
        if(sumRow<minSum) 
        {
            minSum = sumRow;
            index = i+1;
        }
    }
    return index;
}

int m = new Random().Next(3,5), n = new Random().Next(3,5);
int[,] array2D = NewRandomArray(m, n);
Console.WriteLine("Первоначальный массив:");
PrintArray2D(array2D);
Console.Write($"Минимальная сумма элементров в {MinSumRow(array2D)} строке.\t");