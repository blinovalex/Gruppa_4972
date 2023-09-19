// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Выводим результат
void PrintResult( string msg)
{
    Console.WriteLine(msg);
}


long MyPow(int numA, int numB)
{
    long res = 1;
    while (numB > 0)
    {
        res = res * numA;
        numB = numB - 1;
       
    }
     return res;
}

int num1 = ReadData("Введите первое число: ");
int num2 = ReadData("Введите второе число: ");
long res = MyPow(num1, num2);
PrintResult("степень " + num2 + " от числа " + num1 + " равно " + res);