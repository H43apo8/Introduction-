/* Задача 51 Задайте двумерный массив. Найдите сумму элементов находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
например 
1 4 7 2
5 9 2 3
8 4 2 4 
Сумма элементов главной диагонали 1+9+2 = 12*/

Console.Clear();
int GetNumber(string message)





int[,] InitMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    



    matrix[int, j] = rnd.Next(1, 10);
    return matrix;
}

//Сумма главной диагонали
int GetSumm(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        count += matrix[i, i];
    }
    return count;
}

//печать массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int rows = GetNumber("ВВедите кол-во строк: ");
int colums = GetNumber("ВВедите кол-во столбцов: ");
int[,] matrix = InitMatrix(rows, colums);
PrintMatrix(matrix);
int diagonalSum = GetSumm(matrix);
Console.WriteLine($"Сумма элементов главной диагонали: = {diagonalSumm}");
Console.WriteLine();