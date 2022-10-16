//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int a = 2;

while(n >= a)
{
    Console.Write($"{a} ");
    a = a + 2;
}