// 2. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8
int num = new Random().Next(10, 100-1);
Console.WriteLine($"сгенирированное число: {num}");

int x1 = num % 10;
int x2 = num /10;

if (x1 > x2) 
{
    Console.WriteLine($"максимальное число: {x1}");
}
else if (x2 > x1)
{
    Console.WriteLine($"максимальное число: {x2}");
}
else
{
   Console.WriteLine("они равы");
}
