//Программа которая выводит массив 
//и считает его средее арефметическое

int[] Mass (int saze, int from , int to  )
{
   int[]array = new int[saze];
   for (int i = 0; i < saze; i++)
   {
     array[i] = new Random().Next(from , to+1);
   }
 return array;
}
int Print (int[] arr)
{
   int saze = arr.Length ;
   for (int i = 0; i < saze; i++)
   {
    System.Console.Write($"{arr[i]}, ");
   }
   return saze;
}
//1 вариан
double Array (int[] arra)
{
    double count = 0;
    double med = 0;
     for (int i = 0; i < arra.Length; i++)
        {
        count = count + arra[i]; 
        med = count / arra.Length;
        }
  return med;
}
//2 вариан
double Array_1 (int[] arra)
{
   double count = 0;
   
     for (int i = 0; i < arra.Length; i++)
        {
        count = count + arra[i];
        System.Console.Write($"{count}");
        System.Console.WriteLine();
        }
  return count /arra.Length;
}

System.Console.Write("Введите длину массива: ");
int numsize = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());

int[]mass = Mass(numsize,start,stop);

System.Console.WriteLine(mass);

 Print (mass);

 System.Console.ReadLine();

System.Console.WriteLine($"Среднеарефметическая массива 1 вариант = {Array (mass)}");

System.Console.WriteLine();

System.Console.WriteLine($"Среднеарефметическая массива 2 вариант = {Array_1 (mass)}");
