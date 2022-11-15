// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetSpiralArray(int m)
{
    int[,] result = new int[m, m];
    int num = 0;
    for (int i = 0; i < m / 2; i++)
    {
        for (int j = i; j < m - i; j++)
        {
            num++;
            result[i, j] += num;
        }
        for (int k = i + 1; k < m - i; k++)
        {
            num++;
            result[k, m - i - 1] += num;
        }
        for (int l = m - 2 - i; l >= 0 + i; l--)
        {
            num++;
            result[m - i - 1, l] += num;
        }
        for (int o = m - 2 - i; o > 0 + i; o--)
        {
            num++;
            result[o, i] += num;
        }
    }
    if (m % 2 != 0)
    {
        num ++;
        result[m / 2, m / 2] = num;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк и столбцов в массиве: ");
int rc = int.Parse(Console.ReadLine()!);
int[,] array = GetSpiralArray(rc);
PrintArray(array);


