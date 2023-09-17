//Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
int ReadData( string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()?? "0");
    return num;


}

void printResult(string msg)
{
    Console.WriteLine(msg);
}