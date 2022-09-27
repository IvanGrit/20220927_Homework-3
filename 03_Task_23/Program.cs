// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
Clear();
WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

for (int i = 1; i <= a; i++)
{
    Write($"{Math.Pow(i,3)} ");
}