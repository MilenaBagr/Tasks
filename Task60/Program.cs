// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводите массив, 
// добавляя индексы каждого элемента.

int [,,] Create3DMatrix(int rows, int columns, int depth, int min, int max)
{
    int [,,] matr3D = new int [rows,columns,depth];
    Random rnd = new Random();
    for (int i = 0; i < matr3D.GetLength(0); i++)
    {
        for (int j = 0; j < matr3D.GetLength(1); j++)
        {
            for (int k = 0; k < matr3D.GetLength(2); k++)
            {
                matr3D[i,j,k] = rnd.Next(min, max+1);
            }
        }
    }
    return matr3D;
}

void PrintMatrix3D(int[,,] matr3D)
{
    for (int i = 0; i < matr3D.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr3D.GetLength(1); j++)
        {
            for (int k = 0; k < matr3D.GetLength(2); k++)
            {
                if (k<matr3D.GetLength(2)) Console.Write($"{matr3D[i,j,k], 2}[{i},{j},{k}],  ");
                else Console.WriteLine($"{matr3D[i,j,k], 2}[{i},{j},{k}]");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int [,,] matrix3D = Create3DMatrix(3, 4, 5, 10, 50);
PrintMatrix3D(matrix3D);