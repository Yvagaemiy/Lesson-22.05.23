﻿// Задача 41: Пользователь вводит
//  с клавиатуры M чисел. Посчитайте, 
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int MekArray(int num)
{
    int count = 0;
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"число {i}: ");
        int numuser = Convert.ToInt32(Console.ReadLine());
        if (numuser > 0) count++;
    }
    return count;
}

Console.Write("Введите M чисел: ");
int numuser= Convert.ToInt32(Console.ReadLine());
int result =  MekArray(numuser);
Console.WriteLine($"количество чисел больше 0: {result}");
























