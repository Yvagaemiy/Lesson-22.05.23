﻿// 3. Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

double numA = new Random().Next(1, 100);
Console.WriteLine($"сгенерированное число1: {numA}");

double numB = new Random().Next(1, 100);
Console.WriteLine($"сгенерированное число2: {numB}");

if (numB % numA ==0)
{
   Console.WriteLine($"кратно {numB / numA}");   
}
else
{
    Console.WriteLine($" не кратно остаток: {numB / numA }");
}
 