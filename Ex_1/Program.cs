/* Задача 12. Программа, которая выводит случайные числа из отрезка [10, 99] 
и показывает наибольшую цифру числа (78->8)*/

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}

int GetMaxDigit(int number)
{
    int digit1 = number % 10;
    int digit2 = number / 10;
    int max = 0;
    if (digit1 > digit2)
    {
        max = digit1;
    }
    else
    {
        max = digit2;
    }
    return max;
}

for (int i = 0; i < 30; i++)
{
int randomNumber = GetNumberFromRange(10, 99);
int maxDigit = GetMaxDigit(randomNumber);

System.Console.WriteLine($"В числе {randomNumber} максимальная цифра {maxDigit} ");
}