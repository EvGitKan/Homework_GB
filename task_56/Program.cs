// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

//Поиск в массиве строки с минимальной суммой элементов.
int MinSumElementsToRow(int[,] newMatrix)
{
    int result = 0;
    int numberRow = 0;
    int sumElements = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        sumElements = 0;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            sumElements += newMatrix[i, j];
        }
        if (sumElements < result)
        {
            numberRow = i;
            result = sumElements;
        }
        else if (i == 0)
        {
            result = sumElements;
        }
    }
    return numberRow + 1; //добавили 1 для корректного отображения номера строки пользователю
}


int[,] newArray = GenerateMatrixIntNum(5, 3);
PrintMatrixIntNum(newArray);
int row = MinSumElementsToRow(newArray);
Console.Write($"Cтрока массива с наименьшей суммой элементов - {row}");
