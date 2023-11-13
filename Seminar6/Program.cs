// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"{x}, {y}");

// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// int positiveCount = 0;
// Console.Write("Введите количество чисел: ");
// int count = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < count; i++)
// {
//     Console.Write("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number > 0)
//     {
//         positiveCount++;
//     }
// }

// Console.Write(positiveCount);



// // Задача 37: Найдите произведение пар чисел в одномерном массиве.
// // Парой считаем первый и последний элемент, второй и предпоследний
// // и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = GetArray(size, 0, 10);
// PrintArray(array);
// Console.WriteLine("Результат через копирование массива: ");
// PrintArray(CopyArray(array));
// Console.WriteLine("Результат через изменение искомого массива: ");
// ReverseArray(array);
// PrintArray(array);
// // PrintArray(GetMultiplyArray(array));
// // Массив на size элементов, элемент - число от 0 до 10 вкл.
// int[] GetArray(int size, int min, int max)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         // Next(0,2) => 0, 1
//         res[i] = new Random().Next(min, max + 1);
//     }
//     return res;
// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine($"Массив: [{String.Join("; ", arr)}]");
// }

// // 1 способ "поворота": создать копию массива,
// // копия массива = перевернутый "оригинальный массив"

// int[] CopyArray(int[] array)
// {
//     int[] copy = new int[array.Length];  // copy = [0,0]
//     // Размер копии = размеру оригинала
//     // i - индекс "первого" эл. для нового массива copy
//     // j - индекс посл. эл. из старого массива array
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         copy[i] = array[j];
//         // array = [10,20]
//         // copy[0] = array[1]; copy = [20,0], array[1]=20
//         // i++(1), j-- (0)
//         // copy[1] = array[0]; copy = [20,10], array[0]=10
//     }
//     return copy;
// }

// // 2 способ: "поворот" массива без создания доп. массивов 
// void ReverseArray(int[] arr)
// {
//     for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
//     {
//         int temp = arr[i]; // arr[0], [1,2,3,4,5], temp = 1
//         arr[i] = arr[j]; // arr[0] = arr[j], 
//         // первый элемент = последнему: [5,2,3,4,5]
//         arr[j] = temp; // [5,2,3,4,temp], temp = 1
//         // [5,2,3,4,1]
//     }
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// int a = 3;
// int b = 4;
// int c = 5;
// // IsTriangle - "это треугольник?"
// bool IsTriangle(int a, int b, int c)
// {
//     // 7>5 && 8>4 && 9>3
//     return ((a + b) > c && (a + c) > b && (b + c) > a);
// }
// if (IsTriangle(a, b, c)) // IsTriangle(a, b, c) == true
// {
//     Console.WriteLine("Треугольник СУЩЕСТВУЕТ");
// }
// else
// {
//     Console.WriteLine("Треугольник НЕ СУЩЕСТВУЕТ");
// }

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.Write("Введите количество чисел Фибоначчи: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 2)
// {
//     return;
// }
// int[] resArray = GetFibonacciArray(N);
// PrintArray(resArray);
// int[] GetFibonacciArray(int size)
// {
//     int[] array = new int[size]; // [0,0...0]
//     array[0] = 0;
//     array[1] = 1; // 2 - номер элемента
//     // index = i
//     for (int index = 2; index < size; index++)
//     {
//         array[index] = array[index - 1] + array[index - 2];
//     }
//     return array;
// }