// напишите программу которая будет преобразовывать 10чное число в 2ичное
Console.Clear();

string GetBinaryFromDecimal(int decimalNumber)
{
    int number = decimalNumber;
    int ostatok = 0;
    string result = String.Empty;

    while (number >= 1)
    {
        ostatok = number % 2;
        number /= 2;
        if (ostatok != 0)
        {
            result += "1";
        }
        else
        {
            result += "0";
        }
    }
    return new string (result.Reverse().ToArray());
}
Console.WriteLine(GetBinaryFromDecimal(11));
