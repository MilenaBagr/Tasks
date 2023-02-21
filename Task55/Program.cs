// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменит строки на столбцы. В случае, если это невозможно, 
// програма должна вывести сообщение для пользователя.

int [,] CreateNewMatrix (int rows, int columns, int min, int max)
{
    int [,] matr = new int [rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matr[i,j] = rnd.Next(min, max+1);
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
            if (j< matr.GetLength(1)-1) Console.Write($"{matr[i,j], 3}, ");
            else Console.Write($"{matr[i,j], 3}");
        }
        Console.WriteLine("]");
    }
}

int [,] CreateModifiedMatrix(int [,] matr)
{
    int [,] matr2 = new int [matr.GetLength(0),matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr2[i,j] = matr[j,i];
        }
    }
    return matr2;
}

bool CheckRange(int [,] matr)
{
    if (matr.GetLength(0) == matr.GetLength(1)) return true;
    else return false;
}

int [,] matrix = CreateNewMatrix(4, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();

if (CheckRange(matrix) == true) 
{
    int [,] matrix2 = CreateModifiedMatrix(matrix);
    PrintMatrix(matrix2);
}
else Console.WriteLine("Замена невозможна");