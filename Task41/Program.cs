// Задача 41. Пользователь вводит с клавиатуры М чисел. 
// Посчитайте сколько чисел больше 0 ввел пользователь.

Console.Write("Сколько чисел Вы введете? ");
int number = Convert.ToInt32(Console.ReadLine());

int [] NewArray(int num)
{
    int [] arr = new int [num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int PositNumbers(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count +=1;
    }
    return count;
}

int [] array = NewArray(number);
int count = PositNumbers(array);
Console.Write("Вами введенные числа: ");
PrintArray(array);
Console.WriteLine($"Количество чисел, которые больше 0 --> {count}");