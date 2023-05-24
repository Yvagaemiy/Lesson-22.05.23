
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите чмсло от 1 до 7");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 )
{
    Console.WriteLine(" Суббота ");
}
else if (num == 7)
{
     Console.WriteLine("Воскресенье ");
}
else if (num ==1 )
{
     Console.WriteLine("Будни ");
}
else if (num ==2 )
{
     Console.WriteLine("Будни ");
}
else if (num ==3 )
{
     Console.WriteLine("Будни ");
}
else if (num ==4 )
{
     Console.WriteLine("Будни ");
}
else if (num ==5 )
{
     Console.WriteLine("Будни ");
}
else
{
    Console.WriteLine("Токого дна не существует ");
}
