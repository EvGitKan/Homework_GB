// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// Метод для ввода запрашиваемых данных от пользователя.
int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// Сгенерируем случайный двумерный массив, чтобы не вводить вручную.
int[,] GenerateMatrixIntNum(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 100);
        }
    }
    return matrix;
}

void PrintMatrixIntNum(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Console.Write($"{newMatrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

// Метод для вывода элемента массива или сообщения, что такого элемента нет.
// Для удобства пользователя счет строк и столбцов начинается с 1, а не с 0.
void PrintValueElement(int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        Console.WriteLine($"В указанной позиции находится значение {array[row - 1, column - 1]}");
    }
    else Console.WriteLine($"Элемент [{row}, {column}] не входит в диапазон массива [{array.GetLength(0)}, {array.GetLength(1)}].");
}

int[,] newArray = GenerateMatrixIntNum(4, 5);
PrintMatrixIntNum(newArray);
int rowsElement = InputNumber("Введите строку, где находится элемент:");
int columnElement = InputNumber("Введите столбец, где находится элемент:");
PrintValueElement(newArray, rowsElement, columnElement);

