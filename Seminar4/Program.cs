//Методы: воз-т значения и void
// тип метода ИмяМетода(параметр1б параметр2)

using System.Runtime.ConstrainedExecution;
using Internal;

int Calculate(int first, int second, char sing)
{
    if (sing == '+')
    {
        return first + second;
    }
    else if (sing == '-')
    {
        return first - second;
    }
    else if (sing == '*')
    {
        return first * second;
    }
    else
    {
        Console.WriteLine("Ошибка! Введен не верный знак операции");
        return 0;
    }
}