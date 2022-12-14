/*Задайте одномерный массив из 123 случайных числе.
 * Найдите количество элементов массива, значение которых лежат в отрезке от 10 до 99*/

Console.Clear();
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-20, 20);
    }
    return array;
}

// Печать массива на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Count(int[] array, int min, int max)
{
    int result = 0;
    for (int i=0;i<array.Length;i++)
    {
        if ((array[i] >= min) && (array[i] <= max))
                result++;
        
    }
    return result;
}
int[] a = InitArray(23); // int[] a = {5, 18, 123, 6, 2}
Console.WriteLine(String.Join(" ", a));
Console.WriteLine(Count(a, 10, 99));

