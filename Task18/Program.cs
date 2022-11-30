// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");
string quarter = Console.ReadLine();

string Range (string quarter)
{

    if (quarter == "1") return "x > 0 и y > 0";
    if (quarter == "2") return "x < 0 и y > 0";
    if (quarter == "3") return "x < 0 и y < 0";
    if (quarter == "4") return "x > 0 и y < 0";
    return "Введены неверные данные.";
}
string range = Range(quarter);
Console.WriteLine(range);
