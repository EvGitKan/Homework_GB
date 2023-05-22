// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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
            Console.Write($"{newMatrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

//Сортировка строк двумерного массива по убыванию.
int[,] SortDescRowsArray(int[,] array)
{
    int tempValue = 0;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[k, j] > array[k, j - 1])
                {
                    tempValue = array[k, j - 1];
                    array[k, j - 1] = array[k, j];
                    array[k, j] = tempValue;
                }
            }
        }
    }
    return array;
}


int[,] newArray = GenerateMatrixIntNum(5, 5);
PrintMatrixIntNum(newArray);
Console.WriteLine();
int[,] sortArray = SortDescRowsArray(newArray);
PrintMatrixIntNum(sortArray);
