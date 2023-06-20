
// Задача 4: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного 
// копирования.

double[] MekArray(int size, int from, int to)
{
   double[] array = new double[size];
   for (int i = 0; i < size; i++)
   {
     array[i] = new Random().Next(from, to+1);
   }
    return array;
}

int PrintArray(double []array)
{
   int size = array.Length;
   for (int i = 0; i < size; i++)
   {
     System.Console.Write($"{array[i]} ");
   }
    return size;
}
double[] CopArray(double[]arr)
{
    
    int size = arr.Length;
   double[] new_arr = new double[size];
    for (int i = 0; i < size; i++)
    {
       new_arr[i]= arr[i]  ;
    }
    return new_arr;
}


System.Console.Write("Введите длину массива: ");
int numsize = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите конец массива: ");
int stop = int.Parse(Console.ReadLine()!);

double[]mass = MekArray(numsize,start,stop);
PrintArray(mass);

System.Console.WriteLine();

double[]mass_1 = CopArray(mass);
PrintArray(mass_1);