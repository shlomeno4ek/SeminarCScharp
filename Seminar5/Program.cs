// // Задача 31: Задайте массив из 12 элементов, заполненный
// // случайными числами из промежутка [-9, 9]. Найдите сумму
// // отрицательных и положительных элементов массива.

// // тип_возрщ._знач ИмяМетода (пар1, пар2...парN)
// // min = -9, max = 9, массив нa 12 элементов
// int[] res = GetArray(5, -9, 9);
// Console.WriteLine($"Массив искомый: [{String.Join("; ", res)}]");
// int[] GetArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // Изначально массив заполнен нулями
//     for (int i = 0; i < size; i++) // array.Length
//     {
//         // min = -9, max = 9
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// int[] result = GetSum(res);
// Console.WriteLine($"Массив с суммами элементов: [{String.Join("; ", result)}]");
// int[] GetSum(int[] arr)
// {
//     int[] resSum = new int[2]; // resSum = [сум.пол, сум.отрц]
//     int positiveSum = 0; // сумма пол. чисел
//     int negativeSum = 0; // сумма отрц. чисел
//     // "-" - оператор, "50" - операнд
//     // Унарный оператор: работает с 1 операндом (-50), 50
//     // Бинарный оператор: работает с 2 операндами: 2 + 2
//     // Тернарнный оператор: работает с 3 операторами
//     // Условие ? Значение для истины : Значение для лжи
//     for (int i = 0; i < arr.Length; i++)
//     {
//         positiveSum += arr[i] > 0 ? arr[i] : 0;
//         // positiveSum = positiveSum + (arr[i] или 0)
//         negativeSum += arr[i] < 0 ? arr[i] : 0;
//         // negativeSum = negativeSum + (arr[i] или 0)
//     }
//     // resSum = [сум.пол, сум.отрц]
//     resSum[0] = positiveSum;
//     resSum[1] = negativeSum;
//     return resSum;
// }

// // Задача 32: Напишите программу замена элементов
// // массива: положительные элементы замените на
// // соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// int[] res = GetArray(12, -9, 9);
// Console.WriteLine($"Массив искомый: [{String.Join("; ", res)}]");
// int[] GetArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // Изначально массив заполнен нулями
//     for (int i = 0; i < size; i++) // array.Length
//     {
//         // min = -9, max = 9
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] InverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// Console.WriteLine($"[{String.Join("; ", InverseArray(res))}]");

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] res = GetArray(8, 0, 10);
Console.WriteLine($"Массив искомый: [{String.Join("; ", res)}]");
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size]; // Изначально массив заполнен нулями
    for (int i = 0; i < size; i++) // array.Length
    {
        // min = -9, max = 9
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

bool FindElement(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            return true; // true - элемент найден
        }
    }
    return false; // false - элемент не найден
}
if (FindElement(res, number)) // FindElement(res, number) == true
{
    Console.WriteLine($"Элемент {number} присутствует в массиве");
}
else // FindElement(res, number) == false
{
    Console.WriteLine($"Элемент {number} отсутствует в массиве");
}

