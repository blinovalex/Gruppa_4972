// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости,
// в которой находится эта точка.


int ReadData( string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()?? "0");
    return num;


}

int QuteTest(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 31;
    if(x > 0 && y < 0) return 1;
    return 0;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату x: ");
int y = ReadData("Введите координату y: ");

int res = QuteTest(x, y);

PrintResult("Точка находиться в четверти № " + res);



static bool IsPalindrome(int number)
    {
      if (number < 10000 || number > 99999) 
       {
         Console.WriteLine("Число не пятизначное");
         return false;
       }
       char[] data = number.ToString().ToArray();
       if (data[0]&&data[1] == data[3]&&data[4])
       {
       return True;
      }
       else
      {
        return False;