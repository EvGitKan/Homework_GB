// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// Сгенерируем случайный двумерный массив, чтобы не вводить вручную.
int[,] GenerateMatrixIntNum(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrixIntNum(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Console.Write($"{newMatrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

void ArithmeticMeanElements(int[,] newArray)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            result += newArray[i, j];
        }
        double arithmeticMean = Math.Round(result / newArray.GetLength(0), 1);
        Console.Write($"{arithmeticMean}; ");
    }
}


int[,] array = GenerateMatrixIntNum(3, 4);
PrintMatrixIntNum(array);
ArithmeticMeanElements(array);
