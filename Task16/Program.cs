// 16. Напишите программу, которая 

// 1. принимает на вход два числа 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Square(num1, num2) ? "Да" : "Нет");

bool Square( int number1, int number2)
{
    if (number1 == number2 * number2 || number2 == number1 * number1) return true;
    return false;
}
