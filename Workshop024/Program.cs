/*напишите программу которая перевернет одномерный массив
(последний элемент будет на первом месте, а первый на последнем
(1 2 3 4 5) - > {5 4 3 2 1}

1. получение числа 
2. иннициализация массива
3. печать массива
4. поэлементрое копирование массива

*/
Console.Clear();

//1. фунцкция ввода массива 
int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

// 2.Инициализация массива
int[] InitArray(int dimension)
{
    Random rnd = new Random();
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

//3. Печать массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

//4. поворот массива
int[] ReverseArray(int [] array)
{
    int [] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
   {
        result[count] = array[i];
        count++;
   }
   return result;
}

int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);

int[]result = ReverseArray(array);
PrintArray(result);


//ВСТРОЕННАЯ ФУНКЦИЯ

Array.Reverse(result);
PrintArray(result);
