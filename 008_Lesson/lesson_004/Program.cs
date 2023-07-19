// Задача : Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.

int[,]Matrix(int row, int coulmn, int from, int to)
{
  int[,]mass = new int [row, coulmn];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < coulmn; j++)
    
        mass[i,j] = new Random().Next(from, to + 1);
    
  }
    return mass;
}

void PrintMatrix(int[,]array)
{
    int row_size = array.GetLength(0);
    int coulmn_size = array.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < coulmn_size; j++)
        
        System.Console.Write($"{array[i,j], 3}");
        System.Console.WriteLine();
    }
}



System.Console.Write("Введите строки массива : ");
int row_size= Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбцы массива: ");
int coulmn_size= Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива : ");
int start= Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива  : ");
int stop= Convert.ToInt32(Console.ReadLine());

int[,]mass = Matrix ( row_size,  coulmn_size, start, stop);
System.Console.WriteLine("массив 1:");
PrintMatrix(mass);
System.Console.WriteLine();


 int[]MinNum(int[,]arr )
 {
    int row_s = arr.GetLength(0);
    int coulmn_s = arr.GetLength(1);
    int min_num = arr[0 , 0];
    int[] index = new int[2];

    for (int i = 0; i < row_s;i++)
    {
        for (int j = 0; j < coulmn_s; j++)
    
            if ( min_num > arr [i, j] )
            {
                min_num = arr [i, j];
                index[0] = i;
                index[1] = j;  
            }   
    }
    Console.WriteLine(arr[index[0], index[1]]);
    return index; 
}
 void DedRowColumn(int[,]ar, int[] min_index)
 {
    int row_s = ar.GetLength(0);
    int coulmn_s = ar.GetLength(1);

    for (int i = 0; i < row_s; i++)
    {
        for (int j = 0; j < coulmn_s; j++)
        
          if(min_index[0] == i || min_index[1] == j)
          continue;
          
          else
          
          System.Console.Write($"{ar[i,j],3} ");
          
          Console.WriteLine();
         
    }
      
 }
  int[] new_mass = MinNum(mass);
 System.Console.WriteLine("новый массив :");
 DedRowColumn(mass,new_mass);


