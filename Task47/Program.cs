// Задача 47. Задайте двумерный массив размером m*n, 
// заполненный случайными вещественными числами.

double[,] NewRandomMatrix(int rows, int columns, int min, int max)
{
    double[,] matr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 3);
        }
    }
    return matr;
}

void PtintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 6}, ");
            else Console.Write($"{matr[i, j], 6} ");
        }
        Console.WriteLine("]");
    }
}

double[,] matrix = NewRandomMatrix(3, 4, 1, 10);
PtintMatrix(matrix);