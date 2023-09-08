
Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num1 == Math.Pow(num2, 2) ? "Да" : "Нет");

//тернарный  оператор
// <Условие> ? <вариант 1> : <Вариант 2>
//if (num1 == Math.Pow(num2, 2))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
//}
