//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a > 99)
{
    while (a > 1000)
    {
        a = a / 10;
    }
    a = a % 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("третьей цифры нет");
}


