// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadData(string msg) // Выводим запрос числа
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg) // Выводим результат
{
    Console.WriteLine(msg);
}


int SumDigit(int num) // 
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10; // Находим последнюю цифру
        //Console.WriteLine(res);
        num = num / 10; // переход
        //Console.WriteLine(num);

    }
   
    return res;
}

int num = ReadData("Введите число: ");
int res = SumDigit(num);
PrintResult("Сумма цифр в числе " + num + " равно " + res);