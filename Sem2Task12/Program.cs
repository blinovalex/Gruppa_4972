Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()?? "0");
if (numB % numA == 0)
{
    Console.WriteLine("Первое число кратно второму ");
}
else
{
    Console.WriteLine("Второе число не крано первому, остаток от деления  " + (numB % numA));
}