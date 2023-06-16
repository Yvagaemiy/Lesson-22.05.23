// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами. Напишите 
//  программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] MekArray()
{
   int[]arr= new int[4];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100,999);
}
return arr;
}

int PrintArray(int[]array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    return size;
}

int POsitiv(int[]arr)
{
   int count = 0;

   for (int i = 0; i < arr.Length; i++)
   {
    if (arr[i] % 2 ==0)
    {
        count++;
    }
   }
    return count;
}

int[]mass = MekArray();
PrintArray(mass);

POsitiv(mass);

System.Console.WriteLine();
System.Console.WriteLine($"количество чётных чисел в массиве =  {POsitiv(mass)} ");