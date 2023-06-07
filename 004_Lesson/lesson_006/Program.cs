// Задача 2: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
int Fact(int num)
{
    int resulte=1;
    for(int i = 1;i<=num;i++)
    {
    resulte=resulte*i;
    }
    return resulte;
}

Console.WriteLine("ВВидите число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"произведение чисел от {num}! - > {Fact( num)}");



