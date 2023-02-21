// Задача 39. Напишите программу, которая перевернёт 
// одномерный массив(последний элемент будет на первом месте, 
// а первый на последнем и т.д.)

int[] NewRandomArray(int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max+1);
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

void ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = NewRandomArray(5, -10, 10);
PrintArray(array);
ReversArray(array);
PrintArray(array);

Array.Reverse(array);  // встроенный метод переворот массива
PrintArray(array);
