// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;

    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

int SumFromMToN(int m, int n)
{
    //Console.Write(SumMN(m - 1, n));
    int res = SumMN(m - 1, n);
    return res;
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int res = SumFromMToN(numM,numN);
 Console.WriteLine($"Cумму натуральных элементов в промежутке от {numM} до {numN} -> {res} ");