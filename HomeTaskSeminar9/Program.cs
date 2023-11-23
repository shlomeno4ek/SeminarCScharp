// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string printN(int n)
// {
//     if (n == 1) return n.ToString();

//     return n + ", " + printN(n-1);
// }
// Console.Write(printN(n));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(summNumber(m, n));
// int summNumber(int start, int end)
// {
//     if (start == end) return start;

//     return start + summNumber(start + 1, end);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(functionAkkerman(m, n));

// int functionAkkerman(int m, int n)
// {
//     if (m == 0) return (n + 1);
//     if (n == 0) return functionAkkerman(m -1, 1);
//     return functionAkkerman(m - 1, functionAkkerman(m, n -1));
// }