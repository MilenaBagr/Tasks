// Задача 49. Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса четные, и замените эти элементы на их квадраты.

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

int[,] ReplacingEvenElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2)
    {
        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i, j] *= matr[i, j];
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
            else Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] matrix = NewRandomMatrix(3, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[,] replesingMatrix = ReplacingEvenElements(matrix);
PrintMatrix(replesingMatrix);