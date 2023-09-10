//  ------------------------------------------------------
//Задача 9
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
//----------------------------------------------------
void Variant1()
{


    Console.WriteLine("Способ 1");

    System.Random numberGtnerator = new System.Random();
    int number = numberGtnerator.Next(10, 100);
    Console.WriteLine(number);
    // 
    int firsDigit = number / 10;
    //
    int secondDigit = number % 10;

    if (firsDigit > secondDigit)
    {
        Console.WriteLine(firsDigit);

    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
void Variant2()
{
    Console.WriteLine("Способ 2");

    System.Random numberGtnerator1 = new System.Random();
    int number1 = numberGtnerator1.Next(10, 100);
    Console.WriteLine(number1);

    Console.WriteLine((number1 / 10 > number1 % 10) ? (int)(number1 / 10) : (int)(number1 % 10));
}
void Variant3()
{
    Console.WriteLine("Способ 3");

    System.Random numberGtnerator = new System.Random();
    int number = numberGtnerator.Next(10, 100);
    Console.WriteLine(number);

    char [] digitChar = number.ToString().ToCharArray();
    Console.WriteLine((int)digitChar[0] > digitChar[1] ? digitChar[0] : digitChar[1]);
    // 
    
}
Variant1();
Variant2();
Variant3();