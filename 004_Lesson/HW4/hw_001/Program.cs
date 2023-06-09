// Задача 25: Напишите цикл, который принимает
//  на вход два числа (A и B) и возводит число
//  A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Step(int num_A,int num_B)
{
      int resulte = 1;
     for(int i =1;i <=num_B;i++)
    {
    resulte=num_A*resulte;
    }
    return resulte;   
}
System.Console.Write("Введите число А: ");
int num_A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число В: ");
int num_B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"число: {num_A} в {num_B} степени. Равно = {Step( num_A, num_B)}");

