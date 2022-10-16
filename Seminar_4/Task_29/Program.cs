// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] EnteringArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]);
        if (i != col.Length - 1)
        {
            Console.Write(", ");

        }
    }
}

Console.WriteLine("Введите размер вашего массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Заполните ваш массив через Enter: ");
int[] array = EnteringArray(size);
PrintArray(array);



