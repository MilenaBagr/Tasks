﻿// 11. Напишите программу, которая:
// 1. выводит случайное трёхзначное число 
// 2. удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число: {number}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
Console.WriteLine($"Удаляем вторую цифру числа = {RemoveSecondDigit(number)}");