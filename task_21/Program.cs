// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//sqrt((x2-x1)^2 + (y2-y1)^2 + (z2-z1)^2)


int firstPointX = InputNumber("Введите координату X первой точки: ");
int firstPointY = InputNumber("Введите координату Y первой точки: ");
int firstPointZ = InputNumber("Введите координату Z первой точки: ");
int secondPointX = InputNumber("Введите координату X второй точки: ");
int secondPointY = InputNumber("Введите координату Y второй точки: ");
int secondPointZ = InputNumber("Введите координату Z второй точки: ");

double distance = DistanceBetweenPoints(firstPointX, firstPointY, firstPointZ, secondPointX, secondPointY, secondPointZ);
Console.Write($"Расстояние между двумя точками в 3D пространстве = {distance}");

int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double DistanceBetweenPoints(int numX1, int numY1, int numZ1, int numX2, int numY2, int numZ2)
{
    int deltaX = numX2 - numX1;
    int deltaY = numY2 - numY1;
    int deltaZ = numZ2 - numZ1;
    double dist = Math.Round(Math.Sqrt(deltaX ^ 2 + deltaY ^ 2 + deltaZ ^ 2), 1);
    return dist;
}