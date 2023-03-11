// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetArray2DSpiral(int row, int col)
{
    int[,] result = new int[row, col];
    int i = 0, j = 0;
    int maxRow = row, maxCol = col;
    int minRow = 0, minCol = 0;
    int[,] Move = { {0,1},
                    {1,0},
                    {0,-1},
                    {-1,0}  };
    int indexMove = 0;
    for (int k = 1; k < row * col + 1; k++)
    {
        result[i, j] = k;
        int newi = i + Move[indexMove % 4, 0];
        int newj = j + Move[indexMove % 4, 1];
        if (newi >= maxRow || newi < minRow || newj >= maxCol || newj < minCol)
        {
            indexMove++;
            i += Move[indexMove % 4, 0];
            j += Move[indexMove % 4, 1];
            if (indexMove % 4 == 0)
            {
                maxCol--;
                maxRow--;
                minCol++;
            }
            if (indexMove % 4 == 3) minRow++;

        }
        else
        {
            i = newi;
            j = newj;
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
            Console.Write($"{mas[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int n = new Random().Next(3, 6);
int m = new Random().Next(3, 6);

int[,] Array2D = GetArray2DSpiral(n, m);
PrintArray2D(Array2D);