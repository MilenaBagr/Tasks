// Напишите программу, которая

// 1. на вход принимает два числа
// 2.  проверяет, является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число: ");
int squareNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num * num == squareNum) 
{
    Console.WriteLine($"Число {squareNum} является квадратом числа {num}: ");
}
else
{
    Console.WriteLine($"Число {squareNum} НЕ является квадратом числа {num}: ");
}