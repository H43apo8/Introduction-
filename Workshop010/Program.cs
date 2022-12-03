//Принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (((num1 * num1) == num2) || ((num2 * num2) == num1))
{
    Console.WriteLine("ok");
}
else
    Console.WriteLine("Not ok");