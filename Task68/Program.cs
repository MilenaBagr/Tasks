// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int CalculationAckermanFunction(int m, int n)
{
    if (m == 0) return n+1;
    if (n==0) return CalculationAckermanFunction(m-1,1);
    return CalculationAckermanFunction(m-1, CalculationAckermanFunction(m,n-1));
}

void CkeckNegative(int m, int n)
{
    if (m >= 0 && n>=0) 
    {
        int ackermanFunction = CalculationAckermanFunction(m, n);
        Console.WriteLine($"Два неотрицательных числа: {m} и {n} --> {ackermanFunction}");
    }
    else Console.WriteLine("Введены отрицательные числа.");
}

CkeckNegative(m, n);
