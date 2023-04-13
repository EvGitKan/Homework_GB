//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Task(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int num = Task("Введите число: ");
if (num < 100 && num > -100)
{
    Console.WriteLine("В введенном числе нет третьей цифры");
    return;
}

int thirdNum = num / 10 % 10;
Console.Write($"Третья цифра числа {thirdNum}");