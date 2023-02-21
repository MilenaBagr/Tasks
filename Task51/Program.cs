// Задача 51. Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0) (1,1) и тд)

int[,] NewRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int SumDiagonalElements(int[,] matr)
{
    int sum = 0;
    int minLength = matr.GetLength(0);
    if (matr.GetLength(1) < minLength) minLength = matr.GetLength(1);

    for (int i = 0; i < minLength; i++)
    {
        sum += matr[i, i];
    }
    return sum;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = NewRandomMatrix(3, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int sumDiagonalElements = SumDiagonalElements(matrix);
Console.WriteLine($"Сумма элементов, стоящих на главной диагонали имеющегося двумерного массива --> {sumDiagonalElements}");