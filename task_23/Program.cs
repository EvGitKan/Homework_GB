// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int number = InputNumber("Введите число N: ");
GenerateTableCubes(number);

int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void GenerateTableCubes (int num)
{
    int i = 1;
    while(i <= num)
    {
        int cube = Convert.ToInt32(Math.Pow(i, 3));
        Console.WriteLine($"{i}|{cube}");
        i++;
    }
}