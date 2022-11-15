// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] GetRandomNum(int m, int n, int l, int minValue, int maxValue)
{
    int[] array = new int[m * n * l];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = 0; k < i; k++)
        {
            if (array[i] == array[k])
            {
                array[i] = new Random().Next(minValue, maxValue + 1);
                k = 0;
                i = 0;
            }
        }
    }
    return array;
}

int[,,] GetArray(int m, int n, int l, int[] array)
{
    int[,,] result = new int[m, n, l];
    int[,,] temp = new int[m, n, l];
    int index = 0;
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = array[index];
                index++;
            }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i}, {j}, {k})\t ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.WriteLine("Введите длину трёхмерного массива: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите ширину трёхмерного массива: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите высоту трёхмерного массива: ");
int z = int.Parse(Console.ReadLine()!);
int[] array = GetRandomNum(x, y, z, 10, 99);
int[,,] array3D = GetArray(x, y, z, array);
PrintArray(array3D);

