// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).


int num = InputNumber("Введите пятизначное число: ");
string res = num > 9999 && num < 100000 || num < -9999 && num > -100000
             ? CheckPalindrome(num)
             : "Введено не пятизначное число. Повторите попытку ввода";
Console.Write(res);

int InputNumber(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string CheckPalindrome(int number)
{
    string output = number % 10 == number / 10000
                    && (number % 100) / 10 == (number / 1000) % 10
                    ? $"Число {number} является палиндромом."
                    : $"Число {number} не является палиндромом.";
    return output;
}