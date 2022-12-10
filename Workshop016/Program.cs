// Программа считает количество введённых чисел
Console.Clear();
//int GetNumber(int message)
int CountOfDigits(int x)
{
    int cnt = 0;
    while (x>0)
    {
        cnt += 1;
        x /= 10;
    }
    return cnt;
}
Console.WriteLine(CountOfDigits(123456));
