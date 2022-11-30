// Задача 19

// Напишите программу, которая 
// 1. принимает на вход пятизначное число 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string Palindrome(int num)
{
    if (num > 9999 && num < 100000)
    {
        int num1 = num / 10000;
        int num5 = num % 10;
        int num2 = num / 1000 % 10;
        int num4 = num / 10 % 10;
        if (num1 == num5 && num2 == num4) return "Да";
        return "Нет";
    }
    return "Введено не пятизначное число.";
}
string palindrome = Palindrome(number);
Console.WriteLine(palindrome);