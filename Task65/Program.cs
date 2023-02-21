// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbersFromMtoN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMtoN(numM+1, numN);
    }
    else if (numN < numM)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMtoN(numM-1, numN);
    }
    if ( numN == numM) Console.Write($"{numN} ");
}

Console.WriteLine($"Натуральные числа в промежутке от М-> {number1} до N-> {number2} :");
NaturalNumbersFromMtoN(number1, number2);