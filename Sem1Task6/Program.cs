Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");
// if(num % 2 == 0)
// {
//     Console.WriteLine("Даное число четное");
// }
// else
// {
//     Console.WriteLine("Данное число не четное");
//}
Console.WriteLine(num % 2 == 0 ? "Даное число четное" : "Данное число не четное");