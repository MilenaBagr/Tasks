// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int WorkNumb(int num)
{
    int work = 1;
    for (int i = 1; i <= num; i++)
    {
        work = work * i;
    }
    return work;
}

if (number > 0)
{
int workNumb = WorkNumb(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {workNumb}");
}
else Console.WriteLine("Требуется ввести натуральное число.");