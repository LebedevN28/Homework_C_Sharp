// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

// Создание и заполнение массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

// Количество четных элементов
int CountEven(int[] mas)
{
    int count = 0;
    for(int i = 0; i < mas.Length; i++)
    {
        if(mas[i]%2==0) count++;
    }
    return count;
}

int[] array = GetArray(5, 100, 999);
Console.WriteLine($"В массиве [{string.Join(",", array)}], чётных элементов: {CountEven(array)}");
