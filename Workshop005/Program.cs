Console.WriteLine("Введите число: ");
string nstring = Console.ReadLine();
int n = Convert.ToInt32(nstring);

if ((n >= 100) && (n <=999))
{
    Console.WriteLine(n % 10);
}
else
    Console.WriteLine("Неверное число");
    
