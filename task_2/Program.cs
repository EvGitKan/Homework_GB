Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.WriteLine("Число " + firstNum + " больше числа " + secondNum);
}
else if (firstNum < secondNum)
{
    Console.WriteLine("Число " + secondNum + " больше числа " + firstNum);
}
else
{
    Console.WriteLine("Числа равны");
}
