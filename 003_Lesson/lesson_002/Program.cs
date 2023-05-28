// Задача 1: Напишите программу, которая по 
// заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).


void CheckChetvert(int num)
{
   if (num ==1) 
   System.Console.WriteLine(" x> 0 && y > 0");
   else if (num ==2) 
   System.Console.WriteLine ("x> 0 && y > 0");
   else if (num ==3) 
   System.Console.WriteLine("x> 0 && y > 0");
    else if (num ==4) 
   System.Console.WriteLine ("x> 0 && y > 0");
   else
   System.Console.WriteLine ("такой четверти нет"); 
}


Console.WriteLine("введите число: ");
try
{
    
int num = Convert.ToInt32(Console.ReadLine());
CheckChetvert(num);
}
catch 
{
    
     System.Console.WriteLine ("введите целое число"); 
}

