
// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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