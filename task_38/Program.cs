// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



//Чтобы использовалась точка вместо запятой в дробном числе, сменили в программе параметры локализации:
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

//Решение задачи:
double[] GenerateArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble(), 1);
    }
    return array;
}

double MinElementArray(double[] array)
{
    double minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double MaxElementArray(double[] array)
{
    double maxElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double DiffMinAndMax(double minElem, double maxElem)
{
    double diffElements = maxElem - minElem;
    return diffElements;
}

void PrintArray(double[] arrayNum)
{
    for (int i = 0; i < arrayNum.Length - 1; i++)
    {
        Console.Write($"{arrayNum[i]}, ");
    }
    Console.WriteLine($"{arrayNum[arrayNum.Length - 1]}");
}

double[] newArray = GenerateArray(7);
PrintArray(newArray);
double minElementArray = MinElementArray(newArray);
double maxElementArray = MaxElementArray(newArray);
double diffMinAndMax = DiffMinAndMax(minElementArray, maxElementArray);
Console.WriteLine($"Разница между максимальным ({minElementArray}) и минимальным ({maxElementArray}) элементом массива = {diffMinAndMax}");
