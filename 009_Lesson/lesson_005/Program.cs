// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Numer(int A, int B)
{
   int new_num = 1;
   for (int i = 1; i <= B; i++)
   {
     new_num = new_num* A;
   }
   return new_num;
}

int NumberRec (int A, int B)
{
    if(B == 0 ) return 1;
   return A *  NumberRec (A,B-1);

}
System.Console.Write("Введите число       : ");
int A =Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите степень     : ");
int B =Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"рекурсия число [{A}] в [{B}] степени = { NumberRec( A, B)}");

System.Console.WriteLine($"число [{A}] в [{B}] степени          = { Numer( A, B)}");