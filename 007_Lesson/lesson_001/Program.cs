// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
//              ВАРИАНТ№1
// int[,] FullMatrix(int row, int  column, int from, int to )
// {
//    int[,]matrix = new int[row, column];

//    for (int i = 0; i < row; i++)
//    {
//          for (int j = 0; j < column; j++)
        
//          matrix[i,j] = new Random().Next(from, to + 1);
        
//    }  
//     return matrix;
// }

// int PrintMatrix(int[,]mat)
// //void PrintMatrix(int[,]mat)
// {
//  int row_size = mat.GetLength(0);
//  int column_size = mat.GetLength(1);
//     for (int i = 0; i < row_size; i++)
//     {   
//         for (int j = 0; j < column_size; j++)
        
//          System.Console.Write($"{mat[i,j],3} ");//резервируем 3 ячейки
//          System.Console.WriteLine();//для перехода на новую строку
         
//     }  
//     return row_size;
//     return column_size;
// }

// System.Console.Write("Введите количество строк: ");
// int row_s = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите количество столбцов: ");
// int column_s = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите начало массива: ");
// int start = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите конец массива: ");
// int stop = Convert.ToInt32(Console.ReadLine());


// int[,]new_matrix =  FullMatrix( row_s, column_s, start, stop );
// //FullMatrix(new_matrix);
// System.Console.WriteLine( PrintMatrix(new_matrix));

//             ВАРИАНТ№2
int[,] FullMatrix(int[,]array )
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    
        array[i,j] = new Random().Next(-30,30);
  } 
  return array;
}

void PrintArray(int[,]array)
{
    
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    
        System.Console.Write($"{array[i,j],3}");
       System.Console.WriteLine();
  }
 
}

System.Console.Write("Введите количество строк: ");
int row_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int column_s = Convert.ToInt32(Console.ReadLine());


int[,]new_matrix =  new int[row_s, column_s];
FullMatrix(new_matrix);
PrintArray(new_matrix);