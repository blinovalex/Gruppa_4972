﻿//Иван В.
// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// int numLength(int n)
// {
//     return Convert.ToInt32(Math.Log(n,10)+1);
// }

// int n = ReadData("Введите число");
// Console.WriteLine("количество цифр в числе = " + numLength(n));

//Анастасия
// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Считает длинну числа
int NumberLength(int number)
{
    int length = 0;
    while (number > 0)
    {
        number /= 10;
        length++;
    }
    return length;
}

int numLength(int n)
{
    return Convert.ToInt32(Math.Log(n,10)+1);
}

int number = Prompt("Введите число: ");


DateTime d1 = DateTime.Now;
int res1 = numLength(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = NumberLength(number);
Console.WriteLine(DateTime.Now - d2);



Console.WriteLine(NumberLength(number));
