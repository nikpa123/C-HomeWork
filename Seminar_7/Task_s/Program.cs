// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

int[] DivideNumIntoDigits(int number)
{
    int size = 0;
    int num = number;
    while (0 < num)
    {
        num /= 10;
        size++;
    }
    int[] digitOfNum = new int[size];
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        temp = number % 10;
        number /= 10;
        digitOfNum[i] = temp;
    }
    return digitOfNum;
}
void RomanNumberConverter(int number, int[] array)
{
    string RomanNum = String.Empty;
    if (3 < array.Length)
    {
        if (array[3] == 3) RomanNum += "MMM";
        else if (array[3] == 2) RomanNum += "MM";
        else if (array[3] == 1) RomanNum += "M";
    }
    if (2 < array.Length)
    {
        if (array[2] == 9) RomanNum += "CM";
        else if (array[2] == 8) RomanNum += "DCCC";
        else if (array[2] == 7) RomanNum += "DCC";
        else if (array[2] == 6) RomanNum += "DC";
        else if (array[2] == 5) RomanNum += "D";
        else if (array[2] == 4) RomanNum += "CD";
        else if (array[2] == 3) RomanNum += "CCC";
        else if (array[2] == 2) RomanNum += "CC";
        else if (array[2] == 1) RomanNum += "C";
    }
    if (1 < array.Length)
    {
        if (array[1] == 9) RomanNum += "XC";
        else if (array[1] == 8) RomanNum += "LXXX";
        else if (array[1] == 7) RomanNum += "LXX";
        else if (array[1] == 6) RomanNum += "LX";
        else if (array[1] == 5) RomanNum += "L";
        else if (array[1] == 4) RomanNum += "XL";
        else if (array[1] == 3) RomanNum += "XXX";
        else if (array[1] == 2) RomanNum += "XX";
        else if (array[1] == 1) RomanNum += "X";
    }
    if (0 < array.Length)
    {
        if (array[0] == 9) RomanNum += "IX";
        else if (array[0] == 8) RomanNum += "VIII";
        else if (array[0] == 7) RomanNum += "VII";
        else if (array[0] == 6) RomanNum += "VI";
        else if (array[0] == 5) RomanNum += "V";
        else if (array[0] == 4) RomanNum += "IV";
        else if (array[0] == 3) RomanNum += "III";
        else if (array[0] == 2) RomanNum += "II";
        else if (array[0] == 1) RomanNum += "I";
    }
    Console.WriteLine(RomanNum);
}

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = DivideNumIntoDigits(number);
RomanNumberConverter(number, array);
