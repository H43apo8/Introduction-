// напишите программу: присутствует ли заданное число в массиве?
Console.Clear();

int[] Invert(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

int[] RandomInt(int min, int max, int size = 10)
{
    int[] array = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;

}

int[] numbers = RandomInt(min: -10, max: 10);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(string.Join(" ", Invert(numbers)));

void NumExists(int[] array, int target)
{
    for (int i=0; i<array.Length; i++) 
    {
        if (array[i] == target)
        {
            Console.WriteLine($"Число {target} присутствует в массиве");
            return;
        }
    }
    Console.WriteLine("Не нашёл");
}

NumExists(array: new int[] {2, 4, 3, 1}, target: 3);