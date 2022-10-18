// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = Convert.ToDouble(nums[i]);
    }
    return res;
}

double Max (double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double Min (double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

Console.Clear();
Console.WriteLine("Введите числа массива через пробел: ");
string input = Console.ReadLine();
double[] array = GetArrayFromString(input);
Console.WriteLine(String.Join(", ", array));
double sum = Max(array) - Min(array);
Console.WriteLine(sum);