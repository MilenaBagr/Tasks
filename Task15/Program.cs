// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели
// 2. и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

string WeekDay( int day1)
{
    if (day1 > 7 || day1 < 1) return "Такого дня недели не существует";
    if (day1 == 6 || day1 == 7) return "Выходной день";
    return "Рабочий день";
}
string weekDay = WeekDay(day);
Console.WriteLine(weekDay);