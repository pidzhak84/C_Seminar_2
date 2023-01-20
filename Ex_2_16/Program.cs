/*
16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.Write("Введите a = ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите b = ");
int b = int.Parse(Console.ReadLine()!);

if (a == b * b || b == a * a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
