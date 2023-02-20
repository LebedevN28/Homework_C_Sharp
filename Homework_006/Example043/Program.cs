double[] FindXY(double b1, double k1, double b2, double k2)
{
    double[] mas = new double[2];
    mas[0] = (b2 - b1) / (k1 - k2);
    mas[1] = k2 * mas[0] + b2;
    return mas;
}

Console.Write("Введите b1: ");
double B1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
double K1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double B2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double K2 = double.Parse(Console.ReadLine()!);

if (K1 == K2 && B1 != B2) Console.Write("Прямые не пересекаются");
else if (K1 == K2 && B1 == B2) Console.Write("Прямые наложены друг на друга");
else
{
    double[] array = FindXY(B1, K1, B2, K2);
    Console.Write($"Кординаты пересечения:\nX = {array[0]}\nY = {array[1]}\n");
}
