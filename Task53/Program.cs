// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] NewRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
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

void ReplaseRows (int [,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int temp = matr[0,j];
        matr [0, j] = matr[matr.GetLength(0)-1, j];
        matr[matr.GetLength(0)-1, j] = temp;
    }
}

int[,] matrix = NewRandomMatrix(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
ReplaseRows(matrix);
PrintMatrix(matrix);
