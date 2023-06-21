// Решение в группах задач:
// Задача 2: Задайте двумерный массив. Найдите элементы, у которых 
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2      
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] FullMatrix(int row, int  column, int from, int to )
{
   int[,]matrix = new int[row, column];

   for (int i = 0; i < row; i++)
   {
         for (int j = 0; j < column; j++)
         matrix[i,j] = new Random().Next(from, to + 1);     
   }  
  return matrix;
}

//int PrintMatrix(int[,]mat)
void PrintMatrix(int[,]mat)
{
 int row_size = mat.GetLength(0);
 int column_size = mat.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {   
        for (int j = 0; j < column_size; j++) 
         System.Console.Write($"{mat[i,j],3} ");//резервируем 3 ячейки
         System.Console.WriteLine();//для перехода на новую строку         
    }  
    // return row_size;
    // return column_size;
}
void NewArray(int [,]ar)
{
    int row_size = ar.GetLength(0);
    int column_size = ar.GetLength(1);
    for (int i = 1; i < row_size; i+=2)
        {   
        for (int j = 1; j < column_size; j+=2)
        ar[i,j]= ar[i,j]*ar[i,j];
        }
}

System.Console.Write("Введите количество строк: ");
int row_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int column_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());


int[,]new_matrix =  FullMatrix( row_s, column_s, start, stop );
//FullMatrix(new_matrix);
PrintMatrix(new_matrix);

System.Console.WriteLine();
NewArray(new_matrix);
PrintMatrix(new_matrix);
