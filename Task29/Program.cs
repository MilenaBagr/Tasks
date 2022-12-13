// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void RandomArray(int[] arr)
{
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 100);
}
}

void PrintArray(int[] array1)
{
for (int i = 0; i < array1.Length; i++)
{
Console.Write($"{array1[i]} ");
}
}

RandomArray(array);

PrintArray(array);