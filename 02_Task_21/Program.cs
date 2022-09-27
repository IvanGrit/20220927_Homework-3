// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();
Write("Введите координату X первой точки: ");
int a1 = Convert.ToInt32(ReadLine());
Write("Введите координату Y первой точки: ");
int a2 = Convert.ToInt32(ReadLine());
Write("Введите координату Z первой точки: ");
int a3 = Convert.ToInt32(ReadLine());
Write("Введите координату X второй точки: ");
int b1 = Convert.ToInt32(ReadLine());
Write("Введите координату Y второй точки: ");
int b2 = Convert.ToInt32(ReadLine());
Write("Введите координату Z второй точки: ");
int b3 = Convert.ToInt32(ReadLine());
double length = Math.Sqrt(Math.Pow(a1-b1,2) + Math.Pow(a2-b2,2) + Math.Pow(a3-b3,2));
WriteLine($"Расстояние между первой и второй точками составляет {length:f2} единиц");

