// Не используюя рекурсию выведите первые N числа Фибоначи
Console.Clear();

int N = 5;
int x1 = 0;
int x2 = 1;
int res = 0;
string str = "0 1";

for (int i = 2;  i <= N; i++)
{
    res = x2 + x1;
    x1 = x2;
    x2 = res;
    str += res.ToString() + " ";
}

Console.WriteLine(str);
