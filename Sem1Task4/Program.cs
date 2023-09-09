Console.WriteLine("Введите число 1: ");
int numA = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите число 2: ");
int numB = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите число 3: ");
int numC = int.Parse(Console.ReadLine()??"0");
int max = numA;
if(max < numB)
{
    max = numB;     

}
if(max < numC)
{
    max = numC;
}
Console.WriteLine("Из трех чисел максимальное  " + max);