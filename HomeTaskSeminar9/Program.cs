// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// int n = 8;

// printN(n);

// int printN(int n)
// {
//     Console.Write($"{n}, ");
//     if (n == 1) return 1;

//     return printN(n -1);
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = 4;
// int n = 8;

// Console.Write(summNumber(m, n));
// int summNumber(int start, int finish)
// {
//     if (start == finish) return start;

//     return start + summNumber(start + 1, finish);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 2;

Console.Write(functionAkkerman(m, n));

int functionAkkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if (n == 0) return functionAkkerman(m -1, 1);
    return functionAkkerman(m - 1, functionAkkerman(m, n -1));
}