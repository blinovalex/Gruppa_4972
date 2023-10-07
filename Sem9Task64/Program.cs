﻿// // Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + ",");
    }
}

int num = ReadData("Введите число: ");
int count = 1;
NaturalToLow(num,count);