//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int number = 1;

if (a > 99 && a < 1000)
{
    number = a / 10;
    number = number % 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число, попробуйте ещё раз");
}
