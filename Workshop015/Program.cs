// программа принимает на вход число (А) и выдаёт сумму от 1 до (А)
Console.Clear();

/*
 * метотод который получает число с консоли 
 * метод который считает сумму от 1 до n
 * */


//метотод который получает число с консоли 
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) && result > 0)
        { 
            isCorrect= true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число: ");
        }
    }    
    return result;
}


// * метод который считает сумму от 1 до n

int GetSumm(int number)
{
    int summ = 0;

    for (int i=1; i<=number; i++)
    {
        summ += i;
    }
    return summ;
   
}

int number = GetNumber("Введите число больше 0");
int summ = GetNumber(number);

Console.WriteLine($"Сумма чисел от 1 до {number}={summ}");
