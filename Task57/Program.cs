// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию  о том, 
// сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matr)
{
    int[] arr = new int[matr.Length];
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[k++] = matr[i, j];
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.Write("]\n");
}

void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} встречается {count} раз.");
            count = 1;
            num = arr[i];
        }
    }
    Console.WriteLine($"{num} встречается {count} раз.");
}

int[,] matrix = CreateNewMatrix(3, 4, 1, 9);
PrintMatrix(matrix);
int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
CountValue(array);