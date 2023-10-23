//Task 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

// Console.Write("Введите целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень числа: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{a} в степени {b} = {Stepen(a, b)}");

// int Stepen(int number, int stepen)
// {
//     int result = 1;

//     for (int i = 0; i < stepen; i++)
//     {
//         result *= number;    
//     }

//     return result;
// }


//////////////////////////////////////////////////////////////////

//Task 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.

// Console.Write("Введите целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма цифр числа {a} = {SumCifr(a)}");

// int SumCifr (int number)
// {
//     int result = 0;

//     while(number > 0)
//     {
//         result += number % 10;
//         number /= 10;
//     }

//     return result;
// }

//////////////////////////////////////////////////////////////////

//Task 29: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.

int[] result = GetBinaryArray(8);

Console.WriteLine($"[{String.Join("; ", result)}]");

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

int[] GetBinaryArray (int size)
{
    int[] mas = new int[size];

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100);
    }

    return mas;
}
