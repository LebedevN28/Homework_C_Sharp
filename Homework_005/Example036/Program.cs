// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// Сумма нечетных элементов
int SumOdd(int[] mas)
{
    int sumodd = 0;
    for(int i = 1; i<mas.Length; i+=2)
    {
        sumodd+= mas[i];
    }
    return sumodd;
}

int[] array = GetArray(4, -10, 10);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях:\n[{string.Join(",", array)}]\nРавна: {SumOdd(array)}");