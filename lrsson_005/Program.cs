﻿// Напишите программу, которая принимает 
// трехзначное число и показывает последнию цифру.

int NewNumber(int num)
{
 Console.WriteLine(num);   
return  num % 10;
}
int fre_num = new Random().Next(1000-1);
int result = NewNumber(fre_num);
Console.WriteLine(result);


// //% 10 будет показывать последнюю цифру пример 452 % 10 = 2
// //% 100 2-е последние цифры пример 452 % 100 = 52
// // /10 последнюю съедает пример 452 / 10 = 45
// // /100 2-е последние съедает пример 452 / 100 = 4
// // пример соединения 452 / 10 -> 45 % -> 5



