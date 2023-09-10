// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления

using System.Globalization;
void ExtremeСharacters()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine(num);
    // Преводим число в строку и разбираем на символы
    char[] digitChat = num.ToString().ToCharArray();
    Console.Write(digitChat[0]);
    Console.WriteLine(digitChat[2]);
}

ExtremeСharacters();