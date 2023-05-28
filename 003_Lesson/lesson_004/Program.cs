// Задача 2: Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D 
// пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double NewVic(int x, int y,int x1,int y1)
{
    double resulte = Math.Sqrt((y1-y)*(y1-y)+(x1-x)*(x1-x));
    return resulte;
}


Console.Write("x= : ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("y= : ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("x1= : ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("y1= : ");
int y1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(NewVic( x, y,x1, y1));


    



