﻿// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, 0, 10);

// PrintMatrix(array2D); // ДО замены

// Console.WriteLine("`Перевернутая` матрица");

// ChangeRows(array2D); // произошла замена строк
// PrintMatrix(array2D); // Модифицированная матрица
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];  // m стр, n стлб
//     // [кол-во строк, кол-во столбцов]
//     for (int i = 0; i < m; i++) // по стр, m = matrix.GetLength(0)
//     {
//         // j, i, m, k
//         for (int j = 0; j < n; j++)// по стлб, n = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr) // [кол-во строк, кол-во столбцов]
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // по стр, m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// по стлб, n = matrix.GetLength(1)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeRows(int[,] matrix)
// {
//     int indexLastRow = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         // 1 2 3
//         // 4 5 6
//         int temp = matrix[0, i]; // temp = matrix[0, 0], temp  = 1
//         matrix[0, i] = matrix[indexLastRow, i];
//         // 4 2 3
//         // 4 5 6
//         matrix[indexLastRow, i] = temp;
//         // 4    2 3  4 2 3
//         // temp 5 6 ,1 5 6
//     }
// }

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя

int[,] ChangeMatrix(int[,] matr)
{
    int[,] result = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++) // по стр, m = matrix.GetLength(0)
    {
        for (int j = 0; j < matr.GetLength(1); j++)// по стлб, n = matrix.GetLength(1)
        {
            result[j, i] = matr[i, j];
            //j = 1(стл), i = 2(стр)
            // result[1, 2] = matr[2,1]
        }
    }
    return result;
}

// void ChangeRows(int[,] matrix)
// {

//     int indexLastRow = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         // 1 2 3
//         // 4 5 6
//         int temp = matrix[0, i]; // temp = matrix[0, 0], temp  = 1
//         matrix[0, i] = matrix[indexLastRow, i];
//         // 4 2 3
//         // 4 5 6
//         matrix[indexLastRow, i] = temp;
//         // 4    2 3  4 2 3
//         // temp 5 6 ,1 5 6
//     }
// }