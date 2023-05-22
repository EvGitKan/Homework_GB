// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Генерация случайного двумерного массива, чтобы не вводить вручную.
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

//Вывод массива в консоль.
void PrintMatrixIntNum(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Console.Write($"{newMatrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

//Произведение матриц.
int[,] ProductOfMatrices(int[,] oneMatrix, int[,] twoMatrix)
{
    int[,] matrix = new int[oneMatrix.GetLength(0), twoMatrix.GetLength(1)];
    int element = 0;
    int result = 0;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            result = 0;
            for (int j = 0; j < twoMatrix.GetLength(0); j++)
            {
                result += oneMatrix[k, j] * twoMatrix[j, i];
            }
            matrix[k, i] = result;
        }
    }
    return matrix;
}


int[,] array1 = GenerateMatrixIntNum(2, 3);
int[,] array2 = GenerateMatrixIntNum(3, 4);
if (array1.GetLength(1) == array2.GetLength(0))
{
PrintMatrixIntNum(array1);
Console.WriteLine();
PrintMatrixIntNum(array2);
Console.WriteLine();
int[,] productOfMatrices = ProductOfMatrices(array1, array2);
PrintMatrixIntNum(productOfMatrices);
}
else Console.WriteLine("Умножение указанных матриц невозможно, т.к. число столбцов матрицы 1 не равно числу строк матрицы 2.");
