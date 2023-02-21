// Задача 44. Не используя рекурсию, 
// выведите первые N чисел Фибоначчи.\
// Первые два числа Фмбоначчи: 0 и 1.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] Fibonacci(int numb)
{
    int [] arr = new int [number];
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i< arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);   
    }
    Console.WriteLine("]");
}

int [] fibonacci = Fibonacci(number);
PrintArray(fibonacci);