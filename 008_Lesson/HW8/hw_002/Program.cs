
// Задача 56: Задайте прямоугольный 
// двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

int[,]Matrix (int row, int coulmn, int from, int to)
{
  int[,]new_array = new int[row, coulmn];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < coulmn; j++)
    {
        new_array[i,j] = new Random().Next(from, to+ 1);
    }
  }
  return new_array;
}

void PrintMatrix (int[,]arr)
{
    int row_size = arr.GetLength(0);
    int coulmn_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < coulmn_size; j++)
        {
            System.Console.Write($"{arr[i,j], 3}");
        }
      System.Console.WriteLine();
    }
}
int []  SumRow(int[,]ar)
{
   int row_s = ar.GetLength(0);
   int coulmn_s = ar.GetLength(1);
      int[] sum_row = new int[row_s];
     
    for (int i = 0; i < row_s; i++)
    {
       for (int j = 0; j < coulmn_s; j++)
       {
          sum_row[i]  = sum_row[i] + ar[i,j];
       }
    }
    return sum_row;
}
void MinRow(int []arr)
{
    int min = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if( arr[i] < arr[min])
        min = i;
    }
    System.Console.WriteLine($"В {min+1} строке  сумма этих элементов = {arr[min]} ");
}



System.Console.Write("Введите строки массива:");
int row_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбцы массива:");
int coulmn_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива:");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива:");
int stop = Convert.ToInt32(Console.ReadLine());

int[,] new_array =  Matrix( row_s, coulmn_s, start, stop);
 PrintMatrix (new_array);

 int [] new_mass = SumRow(new_array);
 MinRow (new_mass);