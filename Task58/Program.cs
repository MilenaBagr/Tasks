// Задача 58. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

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

bool CheckingСomplianceRange(int[,] matr1, int[,] matr2)
{
    return matr1.GetLength(1) == matr2.GetLength(0);
}

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    int[,] multiplicatMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < multiplicatMatrix.GetLength(0); i++)
    {
        int m = 0;
        for (int j = 0; j < multiplicatMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sum += matr1[i, k] * matr2[k, m];
            }
            multiplicatMatrix[i, j] = sum;
            sum = 0;
            m++;
        }
    }
    return multiplicatMatrix;
}

int[,] matrix1 = CreateRandomMatrix(3, 2, 1, 10);
int[,] matrix2 = CreateRandomMatrix(2, 2, 1, 10);

Console.WriteLine("\nМатрица А: ");
PrintMatrix(matrix1);
Console.WriteLine("\nМатрица В: ");
PrintMatrix(matrix2);

bool checkingСomplianceRange = CheckingСomplianceRange(matrix1, matrix2);

if (checkingСomplianceRange == true)
{
    Console.WriteLine("\nПроизведение матриц А И В: ");
    int[,] multiplicationcatMatrix = MultiplicationMatrix(matrix1, matrix2);
    PrintMatrix(multiplicationcatMatrix);
}
else Console.WriteLine("\nПеремножить матрицы невозможно.");


// и эту задачу спустя неделю решила. наконец дошло