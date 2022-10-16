//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int a = int.Parse(Console.ReadLine()!);

if (a == 6 || a == 7)
{
    Console.WriteLine("выходной");
}
else if (a > 7 || a < 1)
{
    Console.WriteLine("Нет такого дня недели");
}
else 
{
    Console.WriteLine("будний день");
}