Console.WriteLine("Введите число 1: ");
int numA = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2: ");
int numB = int.Parse(Console.ReadLine()??"0");
int max = numA;
if(numA > numB)
{
    Console.WriteLine("Максимальное число " + max);

}
else
{
    max = numB;
    Console.WriteLine("Максимальное число " + max);
}
