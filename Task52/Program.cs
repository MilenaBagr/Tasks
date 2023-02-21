// ЗАдайте двумерный массив из целых чисел, 
// найдите среднее арифметическое в каждом столбце.
int[,] NewRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

double[] ArithmeticMean(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        double result = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        result = sum / matr.GetLength(0);
        arr[j] = Math.Round(result, 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($" {arr[i]}; ");
        else Console.WriteLine($"{arr[i]}.");
    }
}

int[,] matrix = NewRandomMatrix(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца:");
double[] arifmeticArray = ArithmeticMean(matrix);
PrintArray(arifmeticArray);