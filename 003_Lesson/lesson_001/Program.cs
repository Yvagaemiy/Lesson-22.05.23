

// 1. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится 
// эта точка

 

// System.Console.WriteLine("введите координату x:");
// int x = Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine("введите координату y:");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && Y > 0)
// {
//     System.Console.WriteLine("это первая четверть");
// }
// else if (x < 0 && Y > 0)
// {
//     System.Console.WriteLine("это вторая четверть");
// }
// else if (x < 0 && Y < 0)
// {
//     System.Console.WriteLine("это третья четверть");
// }
// else if (x > 0 && Y < 0)
// {
//     System.Console.WriteLine("это четвертая четверть");
// }
// else
// {
//     System.Console.WriteLine("точка находится на координатной оси");
// }


void CheckKoord(int x, int Y)
{
if (x > 0 && Y > 0)
{
    System.Console.WriteLine("это первая четверть");
}
else if (x < 0 && Y > 0)
{
    System.Console.WriteLine("это вторая четверть");
}
else if (x < 0 && Y < 0)
{
    System.Console.WriteLine("это третья четверть");
}
else if (x > 0 && Y < 0)
{
    System.Console.WriteLine("это четвертая четверть");
}
else
{
    System.Console.WriteLine("точка находится на координатной оси");
}
}

 int CheckKoord2(int x, int Y)
{
    int resulte = 0;
if (x > 0 && Y > 0)
    return resulte= 1;
else if (x < 0 && Y > 0)
   return resulte= 2;
else if (x < 0 && Y < 0)
    return resulte= 3;
else if (x > 0 && Y < 0)
   return resulte= 4;

   return resulte;
}
   
Console.Clear();

Console.WriteLine("введите координату x:");
 int x = Convert.ToInt32(Console.ReadLine());


 Console.WriteLine("введите координату y:");
 int Y = Convert.ToInt32(Console.ReadLine());

 CheckKoord( x, Y);//это функция относится к void методу
//  CheckKoord( -5, 2);

System.Console.WriteLine($"это четверть № {CheckKoord2(x, Y)}");//это функция к возврощаемому методу