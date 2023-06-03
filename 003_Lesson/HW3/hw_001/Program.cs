
// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance (int x1,int x2,int y1, int y2, int z1, int z2)
{
    double resulte= Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return resulte;
}
Console.WriteLine("введите точку x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите точку y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите точку z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите точку x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите точку y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите точку z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


Console.Write("расстояние равно: ");
Console.WriteLine(Distance(x1,x2,y1,y2,z1,z2));

// Console.Write($"{Math.Pow(Distance(x1,x2,y1,y2,z1,z2), 3)}, ");