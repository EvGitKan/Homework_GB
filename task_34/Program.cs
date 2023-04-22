// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]  % 2 == 0)
        {
            count++;
        }
    }    
    return count;
}

void PrintArray(int[] arrayNum)
{
    for (int i = 0; i < arrayNum.Length - 1; i++)
    {
        Console.Write($"{arrayNum[i]}, ");
    }
    Console.WriteLine($"{arrayNum[arrayNum.Length - 1]}");
}

int[] newArray = GenerateArray(8);
PrintArray(newArray);
int countEvenNumbers = CountEvenNumbers(newArray);
Console.WriteLine($"Количество четных элементов в массиве = {countEvenNumbers}");


