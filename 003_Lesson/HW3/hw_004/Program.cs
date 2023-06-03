//   Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности
//  и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

 int NumberRev (int num)
{
  int reminder = 0;
  int reverse =  0;
     while (num > 0)
     {
          reminder = num % 10;//Получил остаток, разделив число на 10 
          reverse = (reverse * 10) + reminder;//умножил сумму на 10, а затем добавил напоминание
          num = num / 10;//Получить частное, разделив число на 10
     }
     return reverse;
     return reminder;
}
Console.Write("Ввидите число: ");
int num = Convert.ToInt32(Console.ReadLine());   
Console.WriteLine($"Обратный порядок равен: {NumberRev (num)}"); 

if (num == NumberRev (num))
{
   Console.WriteLine("Это палиндром!");
 }
 else
 {
   Console.WriteLine("Это не палиндром!");
 }



