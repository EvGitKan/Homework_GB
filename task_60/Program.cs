// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


//Генерация трехмерного массива.
int[,,] GenerateMatrixIntNum(int rows, int columns, int num)
{
    int temp = 0;
    int[,,] matrix = new int[rows, columns, num];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                do
                {
                    temp = random.Next(10, 100);
                } while (CheckReplayElement(matrix, temp)); //проверяем каждый новый рандомный элемент на повтор
                matrix[i, j, k] = temp;
            }
        }
    }
    return matrix;
}

//Проверка на повторяющиеся элементы в массиве.
bool CheckReplayElement(int[,,] newArray, int element)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                if (element == newArray[i, j, k])
                {
                    return true;
                    break;
                }
            }
        }
    }
    return false;
}

//Вывод массива в консоль.
void PrintMatrixIntNum(int[,,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                Console.Write($" {newArray[i, j, k],4}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine("|");
    }
}

int[,,] array3D = GenerateMatrixIntNum(2, 2, 2);
PrintMatrixIntNum(array3D);