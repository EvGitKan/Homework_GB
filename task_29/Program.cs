//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}]");
}

int lengthArray = InputNumber("Введите длину массива: ");
int min =  InputNumber("Введите начальное значение для диапазона чисел: ");
int max =  InputNumber("Введите конечное значение для диапазона чисел: ");
int[] arrayElements = GenerateArray(lengthArray, min, max);
PrintArray(arrayElements);