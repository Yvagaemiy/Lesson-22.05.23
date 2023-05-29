// Задача 23
// Напишите программу, которая принимает на
//  вход число (N) и выдаёт таблицу кубов
//   чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Squares(int num)
{
    int counte = 1;
     Console.Write($"{num} -> ");

    while (num >= counte)
    {
        Console.Write($"{Math.Pow(counte, 3)}, ");//меняя цифру меняем квадрат числа, куб и тд 
        counte++;
    }
    Console.WriteLine();
}
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Squares(num);
