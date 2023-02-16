// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// static void Main(string[] args)
// {
//     int[] numbers = new int[8];

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = i + 1;
//     }

//     Console.WriteLine("Elements of the array are: ");
//     foreach (int i in numbers)
//     {
//         Console.WriteLine(i);
//     }
//     Console.ReadLine();
// }


int[] Mass(int n)
{
    int[] mas = new int[n];
    for(int i = 0; i<n; i++)
    {
        mas[i] = int.Parse(Console.ReadLine()!); 
    }
    return mas;
}

void PrintMas(int[] masiv)
{
    for(int i = 0; i<masiv.Length; i++)
    {
        Console.Write($"{masiv[i]} ");
    }
}

Console.Write("Введите длину массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите элементы массива, каждый с новой строчки: ");
PrintMas(Mass(a));


// Ввод массива одной строкой в формате: "12,1,53,64"
// int[] Mass(string s)
// {
//     int cNum = 1;
//     string res = "";
//     int lenS = s.Length;
//     for (int i = 0; i < lenS; i++)
//     {   
//         if (s[i].ToString() == ",") cNum+=1;
//     }
//     int[] result = new int[cNum];
//     int index = 0;
//     for (int i = 0; i < lenS; i++)
//     {   
//         if(i != (lenS-1))
//         {
//             if (s[i].ToString() != ",") res += s[i];
//             else
//             {
//             result[index] = int.Parse(res);
//             index++;
//             res = "";
//             }
//         }
//         else
//         {
//             res += s[i];
//             result[index] = int.Parse(res);
//             index++;
//             res = "";
//         }
//     }
//     return result;
// }

// void PrintMas(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         Console.Write($"{mas[i]} ");
//     }
// }

// Console.Write("Введите числа для создания массива в формате '1,2,3,4' :");
// string l = Console.ReadLine()!;

// PrintMas(Mass(l));
