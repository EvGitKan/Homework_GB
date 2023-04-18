// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = InputNumber("Введите число A: ");
int numberB = InputNumber("Введите число B: ");

int numInDegree = raiseToDegree(numberA, numberB);
Console.Write(numInDegree);

int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int raiseToDegree(int numA, int numB)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

// Ниже описан метод для решения задачи не через цикл:
// int raiseToDegree(int numA, int numB)
// {
//     int result = Convert.ToInt32(Math.Pow(numA, numB));
//     return result;
// }