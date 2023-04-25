// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] InputArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNumber($"Введите {i + 1}-е число: ");
    }
    return array;
}

int CountPositiveNumbers(int[] arrayNum)
{
    int count = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        count += arrayNum[i] > 0 ? 1 : 0;
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


int countNum = InputNumber("Введите количество чисел, которые будут введены с клавиатуры: ");
while(countNum <= 0)
    {
        countNum = InputNumber("Введенное число должно быть положительным. Введите повторно количество чисел: ");
    }
int[] newArray = InputArray(countNum);
PrintArray(newArray);
int countPositiveNumbers = CountPositiveNumbers(newArray);
Console.WriteLine($"Количество введеных чисел больше нуля = {countPositiveNumbers}");