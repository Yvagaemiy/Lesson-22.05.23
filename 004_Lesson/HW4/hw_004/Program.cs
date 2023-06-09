// Задача 26 HARD Напишите программу, которая
//  принимает на вход целое или дробное число
//   и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

// double Sum(double num)
// {
//     double count = 0;
//     for(int i =  0; i < num; i++ )
//     {
//        count = count + num + i ;
//        num = num / 10;
//     }
//     return count;
// }

// System.Console.WriteLine("введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine(Sum( num));

int SumNUm(int num)
{
    
int resulte=0;
 ;
while (num > 0)  
  {
   num=num/10;

   resulte++;
  }
 return resulte;
 
}
Console.WriteLine("введите число");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"количество цифр в чесле: {SumNUm(num)}");
