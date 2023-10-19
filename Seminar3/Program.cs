//"Бесконечный" ввод сообщения
//Если ввели число, бесконечный цикл останавливаем
while(true)
{
    Console.Write("Введите число: ");
    string stringNumber = Console.ReadLine();
    int number; // Ничего не клал в нее
    bool isNumber = int.TryParse(stringNumber, out number);
    // Если isNumber == True, значит строчка stringNumber 
    // состоит ТОЛЬКО из цифр; False - в строке есть буквы.
    // Если в stringNumber только цифры, то 
    // в переменную number попадет само число; иначе - 0
    if(isNumber)
    {
        Console.WriteLine("Вы ввели цифры. Цикл закончился");
        break;
    }

}



