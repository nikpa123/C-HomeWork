// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

int[,] ProductOfTwoMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                product[i, j] = product[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return product;
}

Console.Clear();
Console.Write("Введите количество строк в массивах: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массивах: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] matrix1 = GetArray(row, columns, 0, 10);
int[,] matrix2 = GetArray(row, columns, 0, 10);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
int[,] result = ProductOfTwoMatrices(matrix1, matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
PrintArray(result);