Console.Write("Введите номер дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
// "==" - проверка на равенство (5 == 5 => true)
if (numberOfDay == 1) // Точку с запятой перед "{" НЕ ставлю
{
    Console.WriteLine("Понедельник");
}
else if (numberOfDay == 2)
{
    Console.WriteLine("Вторник");
}
else if (numberOfDay == 3)
{
    Console.WriteLine("Среда");
}
else if (numberOfDay == 4)
{
    Console.WriteLine("Чт");
}
else if (numberOfDay == 5)
{
    Console.WriteLine("Пт");
}
else if (numberOfDay == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberOfDay == 7)
{
    Console.WriteLine("Вск");
}
else // Все случаи, кроме цифр от 1 до 7 
{
    Console.WriteLine("Такого дня недели нет!");
}