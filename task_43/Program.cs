// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double FindX(double numB1, double numK1, double numB2, double numK2)
{
    double x = (numB2 - numB1) / (numK1 - numK2);
    return x;
}

double FindY(double numB1, double numK1, double numX)
{
    double y = numK1 * numX + numB1;
    return y;
}

int numberB1 = InputNumber("Введите b1: ");
int numberK1 = InputNumber("Введите k1: ");
int numberB2 = InputNumber("Введите b2: ");
int numberK2 = InputNumber("Введите k2: ");

double findX = FindX(numberB1, numberK1, numberB2, numberK2);
double findY = FindY(numberB1, numberK1, findX);

Console.WriteLine($"Точку пересечения двух прямых - ({findX}; {findY})");