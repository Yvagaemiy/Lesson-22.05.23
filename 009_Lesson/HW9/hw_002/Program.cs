

// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
    

    //1 вариант

    int Sum (int s, int f)
    {
       int count = s;
       if (s==f) return 0 ;
       s++;
       count= s + Sum ( s,  f);
       return count;

     }
    void SumSum(int s, int f)
    {
     System.Console.Write($"сумма чисел от {s} до {f} = {Sum(s-1, f)}");
    }

    System.Console.Write("введите число M: ");
    int s = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("введите число N: ");
    int f = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine($"не понятное число {Sum (s,f)}");
    SumSum(s, f);



//2 вариант не понимаю почему так происходит
    int SumRec(int start, int finish)
{
    if (start>=finish) return 0;  // это выключатель рекурсии
    return  finish+ SumRec(start, finish-1);
}
void Rec(int start, int finish)
{
    System.Console.Write($"рекурсия правельный ответ {SumRec( start-1, finish)}");
}
System.Console.WriteLine();
System.Console.Write("введите число: ");
int start= Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите число: ");
int finish = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"решение рекурсией  ответ не правельный = {SumRec(start,finish)}");
Rec( start, finish);