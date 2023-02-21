// Задача 45. Напишите программу, которая будет 
// создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] NewRandomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] arr1 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = arr[i];
    }
    return arr1;
}

int[] array = NewRandomArray(10, -10, 10);
PrintArray(array);
int[] copyArray = CopyArray(array);
// copyArray[1] = 333; - сделали проверочку
PrintArray(copyArray);