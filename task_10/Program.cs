//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Task(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int num = Task("Введите трехзначное число: ");
if (num < 100 || num > 999)
{
    Console.WriteLine("Введено не трехзначное число. Повторите попытку ввода.");
    return;
}

int secondNum = num / 10 % 10;
Console.Write($"Вторая цифра числа {num} - {secondNum}");