
// Задача 3: Напишите программу, которая 
// принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

double NewChislo(double num)
{
    double i =1;
    Console.Write($"{num} -> ");

   while( num <+i)
   {
      Console.Write($"{Math.Pow(i, 2)}, ");

        i++;
   }

}
 
Console.WriteLine(" введите число");

double num = Convert.ToInt32(Console.ReadLine());

NewChislo(num);