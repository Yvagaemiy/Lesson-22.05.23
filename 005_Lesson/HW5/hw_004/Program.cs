// Задача HARD STAT необязательная: Задайте массив 
// случайных целых чисел. Найдите максимальный элемент
// и его индекс, минимальный элемент и его индекс, среднее
// арифметическое всех элементов. Сохранить эту инфу в отдельный
// массив и вывести на экран с пояснениями. Найти медианное значение п
// ервоначалального массива , возможно придется 
// кое-что для этого дополнительно выполнить.

int []MekArray(int array)
{
   int[]arr = new int [array];
   for (int i = 0; i < arr.Length; i++)
   {
     arr[i] = new Random().Next(-10,10);
   }
    return arr;
}

int PrintArray(int[]ar)
{
  int size = ar.Length;
  for (int i = 0; i < size; i++)
  {
    System.Console.Write($"{ar[i]} ");
  }

  return size;
}

int MaxIndex(int[]arr)
{
   int max = 0; 
   int index = 0;                        
   for (int i = 0; i < arr.Length; i++)
    {      
        if (max < arr[i])
        {
           max=arr[i]; 
             
         
         if(arr[index]==max)
          
            System.Console.WriteLine($"Max число массива: = {index}");
       } 
          
    } 
      return max;


}
System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]mass = MekArray(size);

PrintArray(mass);
System.Console.WriteLine();
System.Console.WriteLine($"Max число массива: = {MaxIndex(mass)}");
// MaxIndex(mass);


