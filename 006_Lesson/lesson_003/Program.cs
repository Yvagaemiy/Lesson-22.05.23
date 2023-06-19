// Задача 1: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

// bool Treyg(int num_1, int num_2, int num_3)
// {
//     bool summa = false;
//     if(num_1< num_2+num_3 && num_2< num_1+num_3 && num_3 < num_1+num_2)
//     summa = true;
//     else
//     summa = false;

//     return false;

// }

void Treyg(int num_1, int num_2, int num_3)
{
    
    if(num_1< num_2+num_3 && num_2< num_1+num_3 && num_3 < num_1+num_2)
{
    System.Console.WriteLine($"такой треугольник существует ");
}
   else
   {
    System.Console.WriteLine($"такого треугольника нет ");
   }

}


System.Console.WriteLine("Введите длину А: ");
int num_A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите длину В: ");
int num_B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите длину C: ");
int num_C = Convert.ToInt32(Console.ReadLine());

Treyg(num_A,num_B,num_C);

