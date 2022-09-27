// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int[] array = FillArray(5,a);
CheckForPalindrom(array);




int[] FillArray(int length, int num)
{
    int[] result = new int[length];
    int k = 1;
    for (int i = length-1; i >= 0; i--)
    {
        result[i] = num/k%10;
        k = k*10;
    }
    return result;
}

void CheckForPalindrom(int[] NewArray)
{
    if(NewArray[0] == NewArray[4] && NewArray[1] == NewArray[3]) WriteLine("Введенное число является палиндромом");
    else WriteLine("Введенное число не является палиндромом");
}

// void PrintArray(int[] inArray)
// {
//     Write("[ ");
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         Write($"{inArray[i]},");
//     }
//    Write("\b ");
//     WriteLine("]");
// }
