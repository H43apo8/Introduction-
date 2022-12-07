// Программа которая по заданному номеру четверти показывает диапозон коорд.

string myMethod(int quarter)
{
     switch (quarter)
     {
        case 1:
            return "x=0 ... +8      y = 0 ... +8";
            break;
        case 2:
            return "x=0 ... -8      y = 0 ... +8";
            break;
        case 3:
            return "x=0 ... -8      y = 0 ... -8";
            break;
        case 4:
            return "x=0 ... +8      y = 0 ... -8";
            break;
        default:
            return "Нужно ввести число от 1 до 4 (четверть)";
     }
     
}

Console.WriteLine(myMethod(1));
Console.WriteLine("");
Console.WriteLine(myMethod(2));
Console.WriteLine("");
Console.WriteLine(myMethod(3));
Console.WriteLine("");
Console.WriteLine(myMethod(4));
Console.WriteLine("");
Console.WriteLine(myMethod(6));
