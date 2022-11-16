// Задача 4: Напишите программу, которая 

// 1. Принимает на вход три числа 
// 2. Выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
else if (num3 > max)
{
    max = num3;
}
Console.WriteLine($"Число {max} является максимальным.");