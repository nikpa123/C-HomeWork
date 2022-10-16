// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist(int ax, int ay, int az, int bx, int by, int bz)
{
    double result;
    result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    return result;
}

Console.Clear();
Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Длина отрезка АВ равна: {Dist(x1, y1, z1, x2, y2, z2):f2}");