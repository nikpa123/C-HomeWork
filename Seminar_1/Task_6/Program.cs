//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int remainder = 0;
a = a % 2;

if(remainder == a)
{
    Console.Write("Чётное");
}
else
{
    Console.Write("Нечётное");
}





