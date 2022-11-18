// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersRec(int n, int a = 1)
{
    if (a <= n)
    {
        return NumbersRec(n, a + 1) + a.ToString() + " ";
    }
    return String.Empty;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumbersRec(n));