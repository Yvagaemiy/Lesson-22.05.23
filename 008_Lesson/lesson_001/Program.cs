

// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку 
// массива

int[,]MatrixArray(int row, int coulmn, int from, int to)
{
int[,]new_matrix = new int [row, coulmn];
   for (int i = 0; i < row; i++)
   {
       for (int j = 0; j < coulmn; j++) 
       new_matrix[i , j] =new Random().Next(from, to+1);   
   }
   return new_matrix;     
}
void PrintArray(int[,]arr)
{
   for (int i = 0; i < arr.GetLength(0);  i++)
       {
        for (int j = 0; j < arr.GetLength(1); j++)
        System.Console.Write($"{arr[i,j],3} "); 
        System.Console.WriteLine(); 
       }  
}
void Cheng(int[,]arra)
{  
    int row_s = arra.GetLength(0);
    int column_s = arra.GetLength(1);
     for (int i = 0; i < row_s;  i++)
       
        for (int j = 0; j <  column_s; j++)
          {
            int temp = arra[0, j];
            arra[0, j] = arra[row_s - 1, j ];
            arra[row_s -1 , j ] = temp;       
          }  
 }
 



System.Console.Write("Введите строки массива : ");
int row_size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбцы массива: ");
int coulmn_size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива : ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива  : ");
int stop = Convert.ToInt32(Console.ReadLine());

int[,]new_mass = MatrixArray(row_size,coulmn_size , start, stop );
// MatrixArray(new_mass);
PrintArray(new_mass);
 System.Console.WriteLine();
 System.Console.WriteLine("поменяна местами первая и последняя строка ");
 Cheng(new_mass);
 PrintArray(new_mass);