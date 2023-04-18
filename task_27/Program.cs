// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = InputNumber("Введите число: ");
int sum = SumDigitalsNumber(number);

Console.Write($"Сумма цифр в введеном числе равна {sum}");

int InputNumber(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int SumDigitalsNumber(int num)
{
    int result = 0;
    for (; num != 0; num /= 10)
    {
        result = result + num % 10;
    }
    return result;
}