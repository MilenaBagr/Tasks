// Задача 10: Напишите программу, которая 

// 1. принимает на вход трёхзначное число 
// 2. на выходе показывает вторую цифру этого числа

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNum(int num)
{
    if (num > 99 && num < 1000)
    {
        num = num / 10 % 10;
        return num;
    }
    return -1;
}
int res = SecondNum(number);

string result = res > -1 ? $"Вторая цифра числа {number} --> {res}" : "Введено не трехзначное число";
Console.WriteLine(result);