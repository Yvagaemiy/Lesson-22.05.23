// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите пяти значное число: ");
string num = Console.ReadLine();
int number = num.Length;

if (number == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Палиндром: { num }");
    }
    else
    {
        Console.WriteLine($"Не палиндром: { num }");
    }

}
else  
 {
     Console.WriteLine($"Вы ввели не пятизначное число: { num }");
 }