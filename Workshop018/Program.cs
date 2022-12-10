// программа создаёт массив из 8 элементов (0 и 1) и  заполненный массив в случайном порядке

Console.Clear(); 

int[] numbers = new int[8];
Random rnd = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(0, 2);
    Console.Write(numbers[i] + " ");
}