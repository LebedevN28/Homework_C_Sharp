// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

// Создать двумерный массив вещественных чисел
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

// Вывести массив на экран
void PrintArray(int[,] inArray)
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


string TakePositionOfElement(int m, int n, int[,] inArray)
{
    if (m < 0 || n < 0) return "m и n должны быть натуральными";
    string result;
    bool hasElement = m <= inArray.GetLength(0) - 1 && n <= inArray.GetLength(1) - 1;
    if (hasElement)
    {
        result = $"{m},{n} -> {inArray[m, n]}";
    }
    else
    {
        result = $"{m},{n}-> такой позиции в массиве нет";
    }
    return result;
}

Console.Clear();

int rows = new Random().Next(3, 8);
int columns = new Random().Next(3, 8);
int[,] myArray = GetArray(rows, columns, -10, 10);
PrintArray(myArray);
Console.WriteLine();


Console.Write("Введите позиции элемента через пробел: \n");
int[] position = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
int m = position[0], n = position[  1];
Console.WriteLine(TakePositionOfElement(m, n, myArray));