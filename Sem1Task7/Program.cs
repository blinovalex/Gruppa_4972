// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначьное число: ");
int num = int.Parse(Console.ReadLine()??"0");
if(num > 100 && num < 1000)
{
    int lastPigit = num % 10;
    Console.WriteLine("Последняя цифра числа " + num + " это число: " + lastPigit);
}
else
{
    Console.WriteLine("Число не трехзначное");
}