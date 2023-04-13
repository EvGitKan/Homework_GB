//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int i = 0;
int max = 0;
int[] array = new int [3];
while (i < 3)
{
    Console.WriteLine("Введите число " + (i + 1) + ": ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    
    if (array[i] > max)
    {
        max = array[i];
    }

    i++;
}
Console.Write("Максимальное введенное число: " + max);