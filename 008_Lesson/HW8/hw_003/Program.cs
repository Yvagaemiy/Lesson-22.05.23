// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет
//  находить произведение двух матриц.
// Например, даны 2 матрицы:
// 1 2 | 5 6
// 3 4 | 7 8
// Результирующая матрица будет:
// 18 20
// 15 18
// C⋅F=(1 * 5 + 2 * 7 ) |   (1 * 6 +2 * 8)
//    (3 * 5 + 4 * 7 )  |   (3 * 6 + 4 * 8)
// 1 2 | 5 
// 3 4 | 6 
// C⋅F=(1 * 5 + 2 * 6 )   
//    (3 * 5 + 4 * 6 ) 
//   1 |2  5 
//   3 |4  6   токого решения матрицы нет

int[,]Matrix_1 (int row, int coulmn, int front, int to)
{
  int[,]new_mat_1 = new int [row, coulmn];
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < coulmn; j++)
    {
        new_mat_1[i,j] = new Random().Next(front, to +1);
    }
  }
   return new_mat_1;
}

int PrintMatrix_1 (int[,]array_1)
{
   int row_size_1 = array_1.GetLength(0);
   int coulmn_size_1 = array_1.GetLength(1);
   
    for (int i = 0; i < row_size_1; i++)
    {
        for (int j = 0; j < coulmn_size_1; j++)
        {
            System.Console.Write($"{array_1[i,j], 3}");
        }
        System.Console.WriteLine();
    }
    return  row_size_1;
    return coulmn_size_1;
}
System.Console.Write("Введите строки 1 массива :");
int row_s_1 = 2 ;//Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбцы 1 массива:");
int coulmn_s_1 = 2;//Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало 1 массива :");
int start_1 = 1; //Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец 1 массива  :");
int stop_1 = 2;//Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите строки 2 массива :");
int row_s_2 = 2;//Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбцы 2 массива:");
int coulmn_s_2 = 2;// Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало 2 массива :");
int start_2 = 1;//Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец 2 массива  :");
int stop_2 = 2;//Convert.ToInt32(Console.ReadLine());

int[,] new_arr_1 =  Matrix_1( row_s_1, coulmn_s_1, start_1, stop_1);
int[,] new_arr_2 =  Matrix_1( row_s_2, coulmn_s_2, start_2, stop_2);

System.Console.WriteLine("Матрица №1:");
PrintMatrix_1 (new_arr_1);
System.Console.WriteLine("Матрица №2:");
PrintMatrix_1 (new_arr_2); 

int[,] MatrixProduct(int[,] matrix_first, int[,] matrix_second)
{
    int row_size_x = matrix_first.GetLength(0);
    int column_size_X = matrix_second.GetLength(0);
    int[,] raznic_matrix = new int[row_size_x, column_size_X];

    if (row_size_x !=  matrix_second.GetLength(0) || column_size_X !=  matrix_second.GetLength(1)) 
    return raznic_matrix;
    
    for (int i = 0; i < matrix_first.GetLength(0); i++)       
        for (int j = 0; j < matrix_second.GetLength(0); j++)
            for (int k = 0; k < matrix_second.GetLength(1); k++)
            {
             raznic_matrix[i, j] =  raznic_matrix[i, j] +  matrix_first[i, k] * matrix_second[k, j];  
            }                 
   return raznic_matrix;
}

int[,] ras_new_matrix =  MatrixProduct(new_arr_1,new_arr_2);

System.Console.WriteLine("Разница матриц:");
PrintMatrix_1(ras_new_matrix);