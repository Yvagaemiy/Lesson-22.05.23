//  Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1 при помощи рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 6 -> "6, 5, 4, 3, 2, 1"
int NUmber(int num)
{
   int number = 1;
   while (number < num)
   {
    System.Console.Write($"{number}, ");
    number++;
   }
  

    return number;
}

void NumRec(int num, int count)
{
    int count = 1;
    if (count< num ) return ;
    
    NumRec( num,count + 1);
   System.Console.Write (NumRec(num,count));  

}


System.Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NUmber(num));

System.Console.WriteLine($"рекурсия: ");
NumRec( num, count);




