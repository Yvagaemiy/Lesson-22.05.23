// Задача 1: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
//друго метод void

void Summa(int num)
{
    int resulte=0;
  for(int i = 1;i<=num;i++)
   //resulte+=i;//результат плюс старый и счетчик плюс один
  resulte = resulte+i;//складывает все числа до введенного числа соответственно
  Console.WriteLine($"сумма чисел от 1 до  {(num)} равно {resulte}");
  
}

Console.WriteLine("Ввидите число");

int num = Convert.ToInt32(Console.ReadLine());

Summa(num);