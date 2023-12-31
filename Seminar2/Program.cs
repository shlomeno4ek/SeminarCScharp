﻿Console.Write("Введите число: ");
string stringNumber = Console.ReadLine();
// Строчка - массив символов
int number; // Ничего не клал в нее
// TryParse(строчка, out переменная для результата)
bool isNumber = int.TryParse(stringNumber, out number);
// Если isNumber == True, значит строчка stringNumber 
// состоит ТОЛЬКО из цифр; False - в строке есть буквы.
// Если в stringNumber только цифры, то 
// в переменную number попадет само число; иначе - 0
Console.WriteLine($"Длина строки(кол-во символов): {stringNumber.Length}");
if (isNumber && stringNumber.Length >= 3) // isNumber == True
{
    Console.WriteLine("Ваша строчка состоит ТОЛЬКО из цифр");
    Console.WriteLine($"{stringNumber} => {stringNumber[0]}{stringNumber[2]}");
}
else
{
    Console.WriteLine("В строчке присутсвуют буквы ИЛИ длина строки < 3 символов");
}


//Задача 3
// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a % b == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {a % b}");
// }

//Задача 2
// Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Рандомное число: {number}");
// int a = number / 100;
// int b = number % 10; 
// number = a * 10 + b;
// Console.WriteLine(number);


//Задание 1
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Рандомное число: {number}");
// int a = number / 10;
// int b = number % 10; 
// if (a > b )
// {
//     Console.WriteLine(a);
// }
// else if(a < b)
// {
//     Console.WriteLine(b);
// }
