// Задача 22: Напишите программу, которая

// 1. принимает на вход число (N) 
// 2. выдаёт таблицуквадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} -> {i * i}");
    }
}
Square(number);