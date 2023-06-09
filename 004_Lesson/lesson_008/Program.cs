// Задача 1: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна 
// -20.
int PrintArray(int[]arr)
{
     int size = arr.Length;
      for (int i = 0; i < size;i ++)
      {
        System.Console.Write($"{arr[i]} ");

      }
   return size;
    
}
 
int[]MekArray(int size,int from,int to)
{
   int[] arr = new int[size];
   for (int i = 0;i < size;i ++)
   {
    arr[i] = new Random().Next(from, to+1);
   }
  return arr;
}

void SumPosNeg(int[] arr)
{
    int pos;
    int neg;
     pos = 0;
     neg = 0;
     for (int i = 0;i < arr.Length;i ++)
     {
    if(arr[i]>=0)
        {
          pos=pos+arr[i];//pos+=arr[i]
        }
     else 
        {  
           neg=neg+arr[i];
        } 
      
     } 
      Console.ReadLine();
     System.Console.WriteLine($"положительная сумма= +{pos}");
     
     System.Console.WriteLine($"отрецательная сумма= {neg} "); 
}


System.Console.Write("Введите длину: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало диапозона: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец диапозона: ");
int stop = Convert.ToInt32(Console.ReadLine());

int[]mass=MekArray(num,start,stop);

PrintArray(mass);
SumPosNeg(mass);
