// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int DegreeNumber(int numb, int degree)
{
    return (degree > 0) ? numb * DegreeNumber(numb, degree - 1) : 1;
}
int degreeNumb = DegreeNumber(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} = {degreeNumb}");