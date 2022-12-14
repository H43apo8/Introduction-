/*произведение пар чисел (первый и последний, второй и предпоследний) в одномерном массиве и запишите результат в новом массиве*/

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
    for (int i=0; i< array.Length; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = InitArray(GetNumber("Введите число :"));
int length;
if (array.Length % 2 == 0)
    length = array.Length / 2;
else
    length = array.Length / 2 + 1;

int[] result = new int[length];

for (int i =0; i< length; i++)
{
    if (i == array.Lenght - 1 - i)
        result[i] = array[i];
    else
        result[i] = array[i] * array[array.Lenght - 1 - i];
}
PrintArray(array);
PrintArray(result);
    