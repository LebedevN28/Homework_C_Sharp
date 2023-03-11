// Задача 58: Задайте две матрицы. Напишите программу, 
// оторая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray2D(int row, int col)
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

void PrintArray2D(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiArray(int[,] firstMas, int[,] secondMas)
{
    int[,] result = new int[firstMas.GetLength(0), firstMas.GetLength(0)];
    for (int i = 0; i < firstMas.GetLength(0); i++)
    {
        for (int l = 0; l < firstMas.GetLength(0); l++)
        {
            int sum = 0;
            for (int j = 0; j < firstMas.GetLength(1); j++)
            {
                sum += firstMas[i, j] * secondMas[j, l];
            }
            result[i,l] = sum;
        }
    }
    return result;
}

int n = new Random().Next(2, 4);
int m = new Random().Next(2, 4);


int[,] FirstArray2D = GetArray2D(n, m);
Console.WriteLine("First array:");
PrintArray2D(FirstArray2D);
int[,] SecondArray2D = GetArray2D(m, n);
Console.WriteLine("Second array:");
PrintArray2D(SecondArray2D);

Console.WriteLine("Array1 * Array2:");
int[,] ResultArray = MultiArray(FirstArray2D, SecondArray2D);
PrintArray2D(ResultArray);