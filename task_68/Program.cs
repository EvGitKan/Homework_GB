// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0)
    {
        return FunctionAkkerman(numM - 1, 1);
    }
    else return FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1));
}

Console.WriteLine("Введите целое положительное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = FunctionAkkerman(numberM, numberN);
Console.WriteLine(result);