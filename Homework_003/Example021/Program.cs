// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты точки A: ");
double Xa = Convert.ToDouble(Console.ReadLine()!);
double Ya = Convert.ToDouble(Console.ReadLine()!);
double Za = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B: ");
double Xb = Convert.ToDouble(Console.ReadLine()!);
double Yb = Convert.ToDouble(Console.ReadLine()!);
double Zb = Convert.ToDouble(Console.ReadLine()!);

double len = Math.Sqrt((Xb - Xa)*(Xb - Xa) + (Yb - Ya)*(Yb - Ya) + (Zb - Za)*(Zb - Za));

Console.WriteLine($"{len:f2}");