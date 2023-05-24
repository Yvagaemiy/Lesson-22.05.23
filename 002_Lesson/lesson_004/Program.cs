
// 4. Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 
// 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

//int num = new Random().Next(10, 1000-1);
Console.WriteLine("Введите чмсло");
//Console.WriteLine($"сгенерированное число: {num}");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 ==0 && num % 23 == 0)
{
    Console.WriteLine("Да ");
} 
else
{
    Console.WriteLine("Нет");
}