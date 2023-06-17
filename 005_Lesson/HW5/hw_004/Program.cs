// Задача HARD STAT необязательная: Задайте массив 
// случайных целых чисел. Найдите максимальный элемент
// и его индекс, минимальный элемент и его индекс, среднее
// арифметическое всех элементов. Сохранить эту инфу в отдельный
// массив и вывести на экран с пояснениями. Найти медианное значение п
// ервоначалального массива , возможно придется 
// кое-что для этого дополнительно выполнить.

int []MekArray()
{
   int[]array = new int [6];
   for (int i = 0; i < array.Length; i++)
   {
     array[i] = new Random().Next(-50,50);
   }
    return array;
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

void MaxIndex(int[]array)
{
   int max = array[0];
   int max_Index = 0;
   for (int i = 0; i < array.Length; i++)
   {
    if (max > array[i])
   {
     max = array[i];
    System.Console.WriteLine();
    System.Console.WriteLine($"Max = {max}");
   }
   if (max = array[i])
   {
    max_Index = i;
    System.Console.WriteLine();
    System.Console.WriteLine($"Max = {i}"); 
   }
   }
}


int[]mass = MekArray();

PrintArray(mass);

MaxIndex(mass);