﻿//  Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 


using System.Reflection.Metadata;

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()?? "0");
bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numB);
if (test1)
{
    Console.WriteLine("Первое квадрат второго");
}

if (test2)
{
     Console.WriteLine("Второе квадрат первого");
}

if (! test1 || test2)
{
    Console.WriteLine("Числа не квадраты");
}