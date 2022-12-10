// программа принимает на вход число N и выдаёт произведение чисел от 1 до N

/*
Console.Clear();
int GetNumber(string message)
int GetSumm(int number)
{
    int summ = 0;

    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }
    return summ;

}

int number = GetNumber("Введите число больше 0");
int summ = GetNumber(number);
*/

Console.Clear();
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
    isCorrect = true;
}
        else
{
    Console.WriteLine("Ввели не число. Введите число: ");
}
    }    
    return result;
}

int GetMultiply(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = i * result;
    }
    return result;
}

int number = GetNumber("Введите число: ");
Console.WriteLine(number);
int multiply = GetMultiply(number);
Console.WriteLine($"Факториал числа {number} = {multiply}"); 