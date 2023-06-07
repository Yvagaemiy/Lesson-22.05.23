// Задача 2: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ProductNum(int num)
{
    int count=0;
   if(num==1) 
   {
   return 1;
   }
   else 
   {
  count= num*ProductNum(num-1);
   }
   return count;
}

Console.WriteLine("ВВидите число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"произведение числа {num}! -> {ProductNum( num)}");