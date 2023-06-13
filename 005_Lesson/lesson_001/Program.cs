
// Задача 1: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна 
// -20.

int[] MekArray (int size, int from, int to)
{
   int[] array = new int [size];
   for(int i =0;i < size;i++)
   {
    array[i] = new Random().Next(from, to +1);
   }

   return array;
}

int PrintArray(int[]array)
{
   int size= array.Length;
   for(int i =0;i < size;i++)
   {
    System.Console.Write($"{array[i]}  ");
   }
   return size;
}
void SumPolNeg(int[]array)
{
    int pos =0;
    int neg =0;
 //int arr = array.Length;
 for(int i =0; i < array.Length;i++)
 {
     if (array[i]>=0)
    {
        pos=pos + array[i] ;
    }
    else
    {
        neg=neg + array[i];
    }

 }
System.Console.Write($"Сумма полжительных чисел = {pos} ");
Console.ReadLine();
System.Console.Write($"Сумма отрецательных чисел = {neg}");
 }


System.Console.WriteLine("Введите длину");
int numsize = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите начало массива");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите конец массива");
int stop = Convert.ToInt32(Console.ReadLine());

int[] mass = MekArray(numsize ,start,stop);

System.Console.WriteLine(mass);

PrintArray(mass);
Console.ReadLine();
SumPolNeg(mass);