// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

int SumOddElements(int[] newArray)
{
    int sum = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum += newArray[i];
        }
    }
    return sum;
}

void PrintArray(int[] arrayNum)
{
    for (int i = 0; i < arrayNum.Length - 1; i++)
    {
        Console.Write($"{arrayNum[i]}, ");
    }
    Console.WriteLine($"{arrayNum[arrayNum.Length - 1]}");
}

int[] array = GenerateArray(9);
PrintArray(array);
int sumOddElements = SumOddElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива = {sumOddElements}");