//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координату X для точки a");
int Xa = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки a");
int Ya = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Z для точки a");
int Za = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату X для точки b");
int Xb = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки b");
int Yb = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Z для точки b");
int Zb = int.Parse (Console.ReadLine()!);
double s = Math.Sqrt(Math.Pow(Xa-Xb,2)+Math.Pow(Ya-Yb,2)+Math.Pow(Za-Zb,2));
Console.WriteLine($"{s:f2}"); // 2 знака после запятой