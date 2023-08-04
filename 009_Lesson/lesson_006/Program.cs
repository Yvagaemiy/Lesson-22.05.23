// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"




void ValuesSet(int start, int finish)
{
    if (start == finish) return ;
    ValuesSet(start,finish-1 );
    if (finish % 2==0 )
   
     Console.Write($"{(finish )}, ");
    
}
System.Console.Write("введите число M: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("введите число N: ");
int finish = Convert.ToInt32(Console.ReadLine());

System.Console.Write("рекурсия: ");
ValuesSet(start,  finish);

System.Console.WriteLine();
System.Console.Write("функция : ");

void NewNum(int start, int finish)
{
for (int i = start ;i <= finish; i++)
    {
      if( i % 2 ==0)
      Console.Write($"{i}, ");
    }
}
NewNum( start, finish);