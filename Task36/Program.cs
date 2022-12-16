// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] NewArrowRandom(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void ArrPrint(int[] arr)
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
Console.Write("Получившийся массив -> ");

int[] array = NewArrowRandom(10, 0, 9);

ArrPrint(array);

int UnfairPosition(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        result += arr[i];
    }
    return result;
}

int unfairPosition = UnfairPosition(array);
Console.WriteLine($" Сумма нечетных элементов массива равна -> {unfairPosition}");