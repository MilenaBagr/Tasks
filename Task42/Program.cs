// 42. Напишите программу, которая будет преобразовывать
// десятичную систему счисления в двоичную.
// 45 --> 101101
// 3 --> 11
// 2 --> 10

int[] Binary(int numb)
{
    int numb1 = numb;
    int size = 0;
    while (numb1 > 0)
    {
        numb1 /= 2;
        size += 1;
    }
    int[] bin = new int[size];
    for (int i = 0; i < bin.Length; i++)
    {
        bin[bin.Length - i -1] = numb % 2;
        numb /= 2;
    }
    return bin;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] binary = Binary(number); 
PrintArray(binary);
