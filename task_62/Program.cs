// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Генерация  двумерного массива.
int[,] GenerateMatrixIntNum(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int i = 0;
    int j = 0;

    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matrix;
}

//Вывод массива в консоль.
void PrintMatrixIntNum(int[,] newMatrix)
{
for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (newMatrix[i, j] < 10)
            {
                Console.Write("0" + newMatrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = GenerateMatrixIntNum(4, 4);
PrintMatrixIntNum(array);