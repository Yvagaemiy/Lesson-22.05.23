
// Задача 54: Задайте двумерный массив.
//  Напишите программу, которая упорядочит
//   по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,]Matrix(int row, int coulmn, int from, int to)
{
   int[,]new_mass = new int [row, coulmn];

   for (int i = 0; i < row; i++)
   {
        for (int j = 0; j < coulmn; j++)
        {
        new_mass[i,j] = new Random().Next(from, to+1); 
        }  
   }
   return new_mass;  
}

void PrintMatrix(int[,]array)
{
   int row_size = array.GetLength(0);
   int coulmn_size = array.GetLength(1);

   for (int i = 0; i < row_size; i++)
   {
        for (int j = 0; j < coulmn_size; j++)  
        {
            System.Console.Write($"{array[i,j], 3}");
        } 
           System.Console.WriteLine();   
   }    
}
void Cheng (int [,]arr)
{
   int row_s = arr.GetLength(0);
   int coulmn_size = arr.GetLength(1);
   int row_size = arr.GetLength(1);
 
   
   for (int i = 0; i < row_s; i++)
   {
      for (int k = 0; k < coulmn_size; k++)
      
        for (int j = 0; j < row_size - 1; j++)
        
        if (arr[i,j] < arr[i,j+1])
        {
         int temp = arr[i,j]; 
         arr[i,j]= arr[i,j+1];
         arr[i,j+1] = temp;
        }
   }
  
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
PrintMatrix(new_array);

System.Console.WriteLine();

Cheng (new_array );
PrintMatrix(new_array);
