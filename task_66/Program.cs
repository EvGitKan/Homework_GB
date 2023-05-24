// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int numberN = Convert.ToInt32(Console.ReadLine());


int sum = 0;
int sumNaturalNumbers = NaturalNumbers(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sumNaturalNumbers}");


int NaturalNumbers(int numM, int numN)
{
    if (numM > numN)
    {
        sum += numN;
        NaturalNumbers(numM, numN + 1);
        return sum + numM;

    }
    else if (numM < numN)
    {
        sum += numM;
        NaturalNumbers(numM + 1, numN);
        return sum + numN;
    }
    else return 0;
}