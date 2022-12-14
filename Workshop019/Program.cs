/* найдите массив из 12 элкментов заполненный случайгыми числами (от -9 до 9)
Найдите сумму отрицательных и положительных элементов массива*/


/* получить размерномть
 * получить заполненный массив рандом
 * распечатать массив на консоль
 * найти сумму положительных
 * найти сумму отрицательных
 * попробовать сделать в одном методе*/
Console.Clear();
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result>0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число:");
        }
    }
    return result;
}

//получить заполненный массив рандомными числами

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i=0; i<dimension; i++) 
    {
        array[i] = rnd.Next(-20, 20);
    }
    return array;
}

// Печать массива на консоль

void PrintArray(int[] array)
{
    for (int i=0; i< array.Length; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// найти сумму положительных элементов массива

int GetPositiveSumm(int[] array)
{
    int summ = 0;

    for(int i=0; i< array.Length; i++) 
    {
        if (array[i]>0)
            summ += array[i];
    }
    return summ;
}

//найти сумму отрицательных элементов массива

int GetNegativeSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summ += array[i];
    }
    return summ;
}

//КОРТЕЖ:
//1й аргумент - сумма положительных, 2й аргумент - сумма отрицательных
(int, int) GetSumms(int[] array)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            negativeSumm += array[i];
        else 
            positiveSumm += array[i];
            
    }
    return (positiveSumm, negativeSumm);
}




int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
int positiveSumm = GetPositiveSumm(array);
int negativeSumm = GetNegativeSumm(array);

(int posSum, int negSum) = GetSumms(array);



Console.WriteLine($"Сумма отрицательных: {negativeSumm}, Сумма положительных: {positiveSumm}");

Console.WriteLine($"Сумма отрицательных: {negSum}, Сумма положительных: {posSum}");

