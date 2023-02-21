// Задача 54. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного масива.

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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

void SortRowsDescendingOrder(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matr.GetLength(1) ; k++)
            {
                if (matr[i, k] > matr[i, j])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateRandomMatrix(4, 7, 1, 50);
PrintMatrix(matrix);
Console.WriteLine("\nУпорядочим по убыванию элементы каждого массива:");
SortRowsDescendingOrder(matrix);
Console.WriteLine();
PrintMatrix(matrix);