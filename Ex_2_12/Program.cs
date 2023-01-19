/* Вход: два числа.
Вывод: является ли второе число кратным первому. Если число 2 кратно числу 1, то программа выводит остаток от деления.
(34, 5 -> не кратно, остаток 4; 16, 4 -> кратно)
*/

Console.Clear();

Console.Write("Введите number1 - ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите number2 - ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.Write("кратно");
}
else
{
    int rem = number1 % number2;
    Console.Write($"не кратно, остаток от деления {rem} ");
}