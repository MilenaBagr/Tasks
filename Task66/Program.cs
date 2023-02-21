// Задача 66: Задайте значения M и N. Напишите программу, 
// которая выдает сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

Console.Write("Введите значение M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SunNaturalElementFromMtoN(int m, int n)
{
    if (m < n) return m + SunNaturalElementFromMtoN(m + 1, n);
    if (m > n) return n + SunNaturalElementFromMtoN(n + 1, m);
    if (m == n) return m;
    return 0;
}

int sumNaturalElement = SunNaturalElementFromMtoN(number1, number2);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {number1} до {number2} --> {sumNaturalElement}");