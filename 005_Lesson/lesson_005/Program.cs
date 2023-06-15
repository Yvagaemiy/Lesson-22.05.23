// Задача 3: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[]MekArray()
{
   int[]array = new int[15];
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(-100, 100 + 1);
   }
    return array;
}

int PrintArray(int[] array)
{
 int size = array.Length;
 for (int i = 0; i < size; i++)
 {
    System.Console.Write($"{array[i]} ");
 }
    return size;
}

int Distans (int[]array)
{
  int count = 0 ;
  for (int i = 0; i < array.Length; i++)
  {
    
     if (array[i]  >= 9 && array[i] <= 100)
     count++;
  }
  return count;
}

int[] mass = MekArray();

PrintArray(mass);

System.Console.WriteLine();
System.Console.WriteLine($"количество цыфр в отрезке = {Distans (mass)}");