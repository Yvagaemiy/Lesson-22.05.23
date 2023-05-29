
// Задача 3: Напишите программу, которая 
// принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


void Squares(int num)
{
    int counte = 1;
   //  Console.Write($"{num} -> ");

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

