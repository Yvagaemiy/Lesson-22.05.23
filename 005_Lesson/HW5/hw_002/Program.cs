// Задача 36: Задайте одномерный массив,
//  заполненный случайными числами. Найдите
//   сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[]MekArray()
{
   int[]array=new int[6];
   for (int i = 0; i <array.Length; i++)
   {
    array[i] = new Random().Next(-99,100);
   }
    return array;
}

int PrintArray(int[]arr)
{
   int size = arr.Length;
   for (int i = 0; i < size; i++)
   {
    System.Console.Write($"{arr[i]} ");
   }
   return size;
}

int SumNeg(int[]ar)
{
   int resulte=0;
  for (int i = 0; i <ar.Length; i=i+2)
  {
    resulte= resulte+ar[i];
  }
   return resulte;
}



int[]mass=MekArray();
PrintArray(mass);

System.Console.WriteLine();
System.Console.WriteLine($" сумму элементов, стоящих на нечётных индексах =  {SumNeg(mass)}");