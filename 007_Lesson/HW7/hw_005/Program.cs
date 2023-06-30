

int [,]MekMatrix(int row, int column, int from, int to)
{
    int[,]new_matrix = new int[row, column];

    for (int i = 0; i < row; i++)
   {
        for (int j = 0; j < column; j++)
        {
        new_matrix[i,j] = new Random().Next(from, to + 1);
        }
   }
    return new_matrix;
}

void PrintMatrix(int[,] mat)
{
   int row_size = mat.GetLength(0);
   int column_size = mat.GetLength(1);
   for (int i = 0; i < row_size; i++)
   {
        for (int j = 0; j < column_size; j++)
        
            System.Console.Write($"{mat[i,j],3} ");
           System.Console.WriteLine();
        
   }
   
}

//System.Console.Write("Введите строки массива :");
int row_s = 3;//Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Введите столбци массива:");
int column_s = 6;//Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Введите начало массива :");
int start = -9;//Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Введите конец массива  :");
int stop = 9;//Convert.ToInt32(Console.ReadLine());

int[,] new_mass= MekMatrix(row_s,column_s,start,stop);
System.Console.WriteLine();
Console.WriteLine("Исходный массив: ");
     
PrintMatrix(new_mass);

void ReverseMatrix(int[,] arra)
{   
    // int row = arra.GetLength(0);
    // int column = arra.GetLength(1);
    // int row_column = arra.GetLength(1) ;
    for (int i = 0; i < arra.GetLength(0)-1 ; i++)
    {
         for (int l = 0; l <arra.GetLength(1)-1; l++)

            for (int j = 0; j < arra.GetLength(0); j++)

                 for (int k = 0; k < arra.GetLength(1)-1; k++)
               
                if (arra[i, l] > arra[i, l + 1])
                {
                int temp = arra[i, l + 1];
                arra[i, l + 1] = arra[i, l];
                arra[i, l] = temp;
                }
                else 
                {
                    int temp = arra[j, k + 1];
                arra[j, k + 1] = arra[j, k];
                arra[j, k] = temp;
                }            
     }
}
System.Console.WriteLine("После сортировки:");
ReverseMatrix(new_mass);
PrintMatrix(new_mass);
