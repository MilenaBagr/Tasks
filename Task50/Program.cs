// Задача 50: 
// 1. Напишите программу, которая на вход принимает позиции элемента 
// 2. в двумерном массиве, 
// 3. и возвращает значение этого элемента 
// 4. или же указание, что такого элемента нет.

int [,] NewRandomMatrix(int rows, int columns, int min, int max)
{
    int [,] matr = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i, j] = rnd.Next(min, max+1);
        }       
    }
    return matr;
}

void PrintMatrix(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i,j], 2}, ");
            else Console.Write($"{matr[i, j], 2}");
        }
        Console.WriteLine("]");
    }
}

bool CheckingTheRange(int [,] matr, int row, int col) // Checking the Range - проверка диапазона
{
    if (row < 0 || col < 0) return false;
    if (row < matr.GetLength(0) && col < matr.GetLength(1)) return true;
    else return false;
} 

int [,] matrix = NewRandomMatrix(3, 4, 1, 10);
Console.WriteLine("Получившийся массив:");

PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите позицию строки элемента: ");
int line =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбеца элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool range = CheckingTheRange(matrix, line, column);

Console.WriteLine(range ? $"Элемент стоящий на позиции [{line},{column}] --> {matrix[line, column]}" : "Такого элемента нет." );