/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

int x1, y1, z1, x2, y2, z2;
double distance;

Console.WriteLine("Input pointA: ");
Console.Write("Input x1: ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input pointB: ");
Console.Write("Input x2: ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
z2 = Convert.ToInt32(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine("Result is: " + distance);
