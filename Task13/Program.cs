// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа
// 2. или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int num)
{
    if (num < 100) return -1;
    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}
int numbSec = SecondNumber(number);
string res = numbSec > -1 ? $"Третья цифра числа {number} --> {numbSec}" : "Третьей цифры нет";
Console.WriteLine(res);