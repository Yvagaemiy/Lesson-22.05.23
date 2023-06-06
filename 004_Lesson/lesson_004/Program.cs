// Задача 1: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
//

int SumNUm(int num)
{
    
    if(num ==0)  return 1;
    
   int resulte=0;
    while (num != 0)  //НЕ РАВЕН нулю
    {
    num=num/10;
    resulte++;
    }
    return resulte;
}

Console.WriteLine("введите число");

int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"количество цифр в чесле: {SumNUm(num)}");
