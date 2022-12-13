// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натурaльное число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < 0) Console.WriteLine("Введено не натуральное число В.");

int Squaring(int num1, int num2)
{
    int res = 1;
    for (int count = 1; count <= num2; count++)
    {
        res = num1 * res;
    }
    return res;
}
int squaring = Squaring(number1, number2);
if (squaring > 1) Console.WriteLine($"Число А = {number1} возведенное в степень числа В = {number2} --> {squaring}");