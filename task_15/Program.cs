// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int WeekDay(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt16(Console.ReadLine());
    return result;
}

void CheckWeekend(int day)
{
    if (day > 5)
    {
        Console.Write($"День {day} является выходным");
    }
    else
    {
        Console.Write($"День {day} не является выходным");
    }
}


int day = WeekDay("Введите день недели в числовом формате: ");

while (day < 0 || day > 7)
{
    Console.WriteLine("Введенный день не является днем недели. Повторите попытку ввода");
    day = WeekDay("Введите день недели в числовом формате: ");
}
CheckWeekend(day);
