// Задача 59. Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] CreateNewMatrix(int rows, int columns, int min, int max)
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

void MatrixMinElementPosition(int[,] matr, out int minRowIndexPos, out int minColumnIndexPos)
{
    minRowIndexPos = 0;
    minColumnIndexPos = 0;
    int minElement = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < minElement)
            {
                minElement = matr[i, j];
                minRowIndexPos = i;
                minColumnIndexPos = j;
            }
        }
    }
}

int [,] NewMatrixDeletedMinPosicionRowsAndColumns(int [,] matr, int minPosRow, int minPosColumns)
{
    int [,] matr2 = new int [matr.GetLength(0)-1, matr.GetLength(1)-1];
    int m = 0;
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        int k = 0;
        if (m == minPosRow) m++;
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            if (k==minPosColumns) k++;
            matr2[i,j] = matr[m,k];
            k++;
        } 
        m++;     
    }
    return matr2;
}

int [,] matrix = CreateNewMatrix(5, 5, 1, 50);
PrintMatrix(matrix);
Console.WriteLine();
int minRowIndexPosicion, minColumnIndexPosicion;
MatrixMinElementPosition(matrix, out minRowIndexPosicion, out minColumnIndexPosicion);
Console.WriteLine($"Минимальное число матрицы c позициями [{minRowIndexPosicion}, {minColumnIndexPosicion}] = {matrix[minRowIndexPosicion,minColumnIndexPosicion]}");
Console.WriteLine();
int [,] matrix2 = NewMatrixDeletedMinPosicionRowsAndColumns(matrix, minRowIndexPosicion, minColumnIndexPosicion);
PrintMatrix(matrix2);