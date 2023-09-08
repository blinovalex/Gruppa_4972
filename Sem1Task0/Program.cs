// Задача №0
// Написать программу, которая на вход принимает число и
// выводит его квадрат.

Console.WriteLine("Введите число ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine(); //?? "0"
// Проверяем , чтобы данные были не пустыми
if (inputNum != null)
{
    //     Парсим введенное число
    //     int num = int.Parse(inputNum);
    //     Находим квадрат числа
    //    int res = num * num;
    //     Выводим данные на консоль
    //     Console.WriteLine(res);

    Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));
}

