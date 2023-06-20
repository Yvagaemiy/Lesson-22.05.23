
// Задача 43: Напишите программу, которая найдёт
//  точку пересечения двух прямых, заданных 
//  уравнениями y = k1x + b1, y = k2x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y = k1x + b1   
//y = k2x + b2  |  k1x + b1 = k2x + b2 | k1x- k2x = b2 - b1 | x= (b2 - b1) / (k1- k2)


void Num (double b1,double k1, double b2, double k2)
{

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"точка пересечения: ({x}; {y})");
 
      if (k1==k2 || -k1==(-k2) )  
    {
    System.Console.WriteLine("точки не пересикаются, граффик параллельный");
    }
   
}
System.Console.Write("Введите точку b1:");
double b_1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите точку k1:");
double k_1 =Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите точку b2:");
double b_2 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите точку k1:");
double k_2 = Convert.ToDouble(Console.ReadLine());

Num( b_1, k_1,  b_2,  k_2);


