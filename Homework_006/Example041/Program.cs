Console.Clear();

int CountPositive(int[] mas)
{
    int result = 0;
    for(int i = 0; i<mas.Length; i++) if(mas[i]>0) result++;
    return result;
}

Console.Write("Введите числа через пробел:\n");
int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();;
Console.WriteLine($"Количество чисел > 0: {CountPositive(array)}");