// Пр-е чисел от 1 до N включительно - факториал
// n! = 1 * 2 * ... * n
// 3! = 1*2*3

// int FindFactorial(int n)
// {
//     // 4! = 4 * 3 * 2 * 1.(точка выхода)
//     // Базовый случай - случай выхода 
//     if (n == 1) return 1;
//     // Рекурсивный случай - там, где и задается рекурсия :)
//     return n * FindFactorial(n - 1);
// }
// int factorial = 5;
// Console.WriteLine($"Факториал от числа {factorial} = {FindFactorial(factorial)}");


// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // start = 1, end = N(3) , start++
// // 1
// string PrintNumbers (int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return (start + "\t" + PrintNumbers(start + 1, end));
// }

// Console.WriteLine(PrintNumbers(1, N));

// Задача 67: Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine(summNumber(453));
// int summNumber(int n)
// {
//     if (n == 0) return 0;

//     return n % 10 + summNumber(n/10);
// }