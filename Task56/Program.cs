// Задача 56. Задайте прямоугольный двумерный массив.  Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void PrintArray(int[] arr)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],2}, ");
        else Console.Write($"{arr[i],2}");
    }
    Console.WriteLine("]\n");
}

int[] SumElementsRows(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = matr[i, j] + sum;
        }
        arr[i] = sum;
    }
    return arr;
}

int SearchLeastSumElementsRows(int[] arr)
{
    int minSumRows = arr[0];
    int indexMinSumRows = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minSumRows)
        {
            minSumRows = arr[i];
            indexMinSumRows = i;
        }
    }
    return indexMinSumRows;
}

int[,] matrix = CreateRandomMatrix(4, 5, 1, 9);
PrintMatrix(matrix);
int[] arraySum = SumElementsRows(matrix);
PrintArray(arraySum);
int indexRowsMin = SearchLeastSumElementsRows(arraySum);
Console.WriteLine($"Строка с наименьшей суммой элементов представленного двумерного массива находится на строке--> {indexRowsMin+1} под индексом [{indexRowsMin}].");

// урааааааа, сама и без подсказок, оказывается могу хоть что-то