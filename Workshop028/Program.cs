﻿// Напишите программу которая будет задавать копию заданного массива с помощью поэлементного копирования
Console.Clear();

int[] array1 = {1, 2, 3, 4, 5};
int[] array2 = new int[array1.Length];

for (int i = 0; i < array1.Length; i++)
    array2[i] = array1[i];

Console.WriteLine(string.Join(" ", array2));
