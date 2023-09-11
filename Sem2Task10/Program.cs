// №10 Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
char[] data = num.ToString().ToArray();
if (data.Length == 3)
{
    Console.WriteLine("Вторая цифра данного числа " + data[1]);
}
else
{
    Console.WriteLine("Вы вели не трехзначное число");
}