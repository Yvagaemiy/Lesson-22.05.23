
// Задача 1: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

//string GetNum (int num)





int GetNum1 (int num)
{
    int number = 1;
    while(number<num)
    {
    System.Console.Write($"{number}, ");//второй вариант System.Console.Write(number+" , ");
     number ++;  
    }
    return number;
}

  void NumRec (int num)
{
  if(num == 0) return;
  NumRec ( num - 1);
  System.Console.Write($"{num}, ");
}

System.Console.Write("введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());


System.Console.Write($"числа в промежутке от 1 до {num}   : ");
System.Console.WriteLine(GetNum1(num));

System.Console.Write($"рекурсия в промежутке от 1 до {num}: ");
NumRec(num);


