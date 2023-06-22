// Задайте двумерный массив. Найдите сумму элементов 
// главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,]MatrixArray(int row, int column, int from , int to)
{  
   int[,]array = new int[row,column];
   
   for (int i = 0; i < row; i++)
   {
    for (int j = 0; j < column; j++)
     
     array[i,j] = new Random().Next(from,to+1);
   }
    return array;
}

void PrintArray(int[,]arr)

{   
    int row_size = arr.GetLength(0);
   int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
   {
    for (int j = 0; j < column_size; j++)
      System.Console.Write($"{arr[i,j],3}");
      System.Console.WriteLine();
   }
 
}

int NewSumArray(int[,]arr)
{
  int sum = 0;

   int row_size = arr.GetLength(0);
   int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
         for (int j = 0; j < column_size; j++)
          {
               if (i==j)
               sum=sum+arr[i,j];
          }
    }

   return sum;
}

System.Console.Write("Введите количество строк: ");
int row_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int column_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());


int[,]new_matrix = MatrixArray ( row_s, column_s, start, stop );

 PrintArray(new_matrix);


System.Console.WriteLine($"Сумма элементов главной диагонали = {NewSumArray(new_matrix)}");
