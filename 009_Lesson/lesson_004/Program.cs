
// Задача 3: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int NewNum(int num)
{
  int count = 0;
  while(num>0)
  {
  count = count + num % 10;
  num = num/10; 
  }
  return count;
}
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"сумма цифр в числе = {NewNum(num)}");

int NewRec(int num)
{
    if(num ==0) return 0  ;
   return num %10 + NewRec(num/10);

}
System.Console.WriteLine($"рекурсия сумма цифр в числе = {NewRec( num)}");