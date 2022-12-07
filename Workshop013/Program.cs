// Программа принимает на вход координаты двух точек и находит расстояние м/д ними в 2D плоскости

Console.WriteLine("Координаты х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance (int x1, int y1, int x2, int y2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;

}

Console.WriteLine($"Расстояние между точками = {Distance(x1, y1, x2, y2)} ");