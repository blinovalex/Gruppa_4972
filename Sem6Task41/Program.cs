// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int CountNumber(string line)
{
    System.Console.Write(line);
    string value =Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

int[] EnteringList(int quantity)
{
    int[] array = new int[quantity];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = CountNumber($"Введите {i+1}-ое число ");

    }
    return array;
}

void InputList(int[] array)
{
    for(int i = 0; i<array.Length;i++)
    Console.WriteLine($"Введеное число {i+1} = {array[i]}");
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = CountNumber("Введите количество чисел ");
int[] array;
array = EnteringList(length);
InputList(array);
Console.WriteLine($"Количество чисел больше 0 - {PositiveNumbers(array)}");