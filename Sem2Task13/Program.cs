// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите  число: ");
int num = int.Parse(Console.ReadLine()?? "0");
char[] data = num.ToString().ToArray();
if (data.Length >= 3)
{
    Console.WriteLine("Третия цифра данного числа " + data[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

// Console.WriteLine(numA % 10);
