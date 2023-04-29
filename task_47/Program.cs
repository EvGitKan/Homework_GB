// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

double[,] GenerateMatrixDoubleNum(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble() * 100, 1);
        }
    }
    return matrix;
}

void PrintMatrixDoubleNum(double[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        Console.Write("|   ");
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Console.Write($"{newMatrix[i, j], 4}   ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2D = GenerateMatrixDoubleNum(3, 4);
PrintMatrixDoubleNum(array2D);