// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[]Mekarray(int size,int from,int to)
{
  int[]array = new int [size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(from, to + 1);
  }
    return array;
}

int PrintArray(int[]arr)
{
   int size = arr.Length;
   for (int i = 0; i < size; i++)
   {
    System.Console.Write($"{arr[i]}, ");
   }
    return size;
}
int Sum(int[]ar)
{
    int cou=0;
   for (int i = 0; i < ar.Length; i++)
   {
    cou++;
   }
   return cou;
}
int[] SumSum(int[]arrr)
{
   int siz = arrr.Length;
   int  new_size = siz / 2 + siz % 2;
   int[]new_arrr = new int[new_size];
   for (int i = 0; i < siz / 2; i++)
    new_arrr[i]= arrr[i]* arrr[siz - i -1];
        if (siz % 2 ==1)
        new_arrr[new_size-1]= arrr[siz / 2];
    return new_arrr;
}


System.Console.Write("введите длину массива: ");
int numsize = int.Parse(Console.ReadLine()!);

System.Console.Write("введите начало массива: ");
int start = int.Parse(Console.ReadLine()!);

System.Console.Write("введите конец массива: ");
int stop = int.Parse(Console.ReadLine()!);

int [] mass = Mekarray(numsize, start, stop);
PrintArray(mass);
System.Console.WriteLine();

System.Console.WriteLine($"количество цыфр в мaссиве =  {Sum(mass)}");//выводит количество цыфр в моссиве

int[] new_mass = SumSum(mass);

PrintArray(new_mass);