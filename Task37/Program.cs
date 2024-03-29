﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] NewArrayRandom(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
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
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] NewArray(int [] arr)
{
    int newArrayLength = arr.Length/2;
    if (arr.Length%2 == 1) newArrayLength +=1;
    int[] newArray = new int [newArrayLength];
    for (int i = 0; i < arr.Length/2; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length%2 == 1) newArray[newArrayLength - 1] = arr[arr.Length / 2];
    return newArray;
}

int [] array = NewArrayRandom(5, 0, 10);
PrintArray(array);
Console.WriteLine();
int [] newArr = NewArray(array);
PrintArray(newArr);