//Напишите программу которая принимает на вход 3 числа и проверяет может ли существовать треугольник со сторонами такой длины
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
Console.Clear();



bool doCalculation(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}

int a = 8;
int b = 10;
int c = 15;

Console.WriteLine($"Стороны: {a}, {b}, {c}");
if (doCalculation(a, b, c))
    Console.WriteLine("Треугольник может существовать");
else
    Console.WriteLine("Треугольник не может существовать");
