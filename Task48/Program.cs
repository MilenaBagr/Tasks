// Задача 48. Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле Аmn = m + n.
// Выведите полученный массив на экран.

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i + j;
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
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 2}, ");
            else Console.Write($"{matr[i, j], 2} ");
        }
        Console.WriteLine("]");
    }
}

int [,] matrix = CreateMatrix(50,50);
PrintMatrix(matrix);