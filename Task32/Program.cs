﻿// Задача 32: 
// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.Write("]");

}

void NegativeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*-1;
    }
}

int[] array1 = CreateArrayRndInt( 10, -30, 30);
PrintArray(array1);
Console.WriteLine();
NegativeArray(array1);
PrintArray(array1);