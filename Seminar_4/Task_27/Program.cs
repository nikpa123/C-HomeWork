// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sum (int number)
{
    int sum = 0;    
    int result = 0;    
    while (0 < number)
    {
        result = number % 10;
        sum = sum + result;
        number = number / 10;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(sum (num));