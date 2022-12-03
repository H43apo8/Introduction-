//Программа выводит случайное 3хзначное число и удаляет вторую цифру этого числа
int GetRandomNumder()
{
    return new Random().Next(100, 1000); //1 ..9
}

void ShowRandomNumber(int number)
{
    Console.WriteLine($"Слцчайное число: {number}");
    string str = number.ToString();
    Console.WriteLine($">{str[0]}{str[2]}");
}

ShowRandomNumber(GetRandomNumder());