Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");
for(int i = 1; i < num; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine("В числе есть четное число " + "" + i);
        
    }
}
