// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;
int Sum(int num)
{
    int summa = 0;
    while ( num > 0)
    {
        summa = summa + num % 10;
        num = num / 10;
    }
    return summa;
}

int sum = Sum(number);
string result = ( sum > 0 ) ? $"Сумма цифр в числе {number} = {sum}" : "Введено неверное значение.";
Console.WriteLine(result);