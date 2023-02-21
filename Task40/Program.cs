// Задача 40. Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triagnle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}

Console.WriteLine(Triagnle(number1, number2, number3) ? "Треугольник может существовать" : "Треугольник не может существовать");
