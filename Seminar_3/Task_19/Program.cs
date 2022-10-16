//Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

void palindrome(int a)
{
    int a1 = a % 10;
    int a2 = a / 10 % 10;
    int a4 = a / 1000 % 10;
    int a5 = a / 10000;
    if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
palindrome(n);
