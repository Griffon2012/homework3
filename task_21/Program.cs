double GetDistanceIn3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(distance, 2);
}

Console.Write("Введите x точки A:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y точки A:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z точки A:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x точки B:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y точки B:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z точки B:");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistanceIn3D(x1, y1, z1, x2, y2, z2));