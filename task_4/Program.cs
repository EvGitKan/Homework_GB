// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}