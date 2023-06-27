// Задача HARD SORT необязательная. 
// Считается за три обязательных
// Задайте двумерный массив из целых 
// чисел. Количество строк и столбцов
//  задается с клавиатуры. Отсортировать
//   элементы по возрастанию слева направо
//    и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10


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
    int row = arra.GetLength(0);
    int column = arra.GetLength(1);
    int row_column = arra.GetLength(1) ;
    for (int i = 0; i < row ; i++)
    {
        for (int j = 0; j < column; j++)

            for (int k = 0; k < row_column - 1; k++)
        
                if (arra[i, k] > arra[i, k + 1])
                {
                int temp = arra[i, k + 1];
                arra[i, k + 1] = arra[i, k];
                arra[i, k] = temp;
                }
                            
     }
}
System.Console.WriteLine("После сортировки:");
ReverseMatrix(new_mass);
PrintMatrix(new_mass);
// void ReverseMatrix(int[,] arr)
// {
//     int size = arr.GetLength(1);
//     for(var i = 0; i < arr.Length -2; i++)
//     {
//         int i1 = arr.Length - i - 1;
        
//         int temp = arr[ i1 / size, i1 % size ];
//         arr[i1 / size, i1 % size] = arr[i / size, i % size];
//         arr[i / size, i % size] = temp;
//     }
  
// }
// System.Console.WriteLine();
// ReverseMatrix(new_mass);
// PrintMatrix(new_mass);
// void RevesArray(int[,]mass)
// {
//     for (int i=0; i<mass.GetLength(0)-1;i++)

//        for (int j=0;j<mass.GetLength(1)-1;j++)
            
//             if (mass[i,j]>mass[i,j+1])
//             {
//             int temp=mass[i,j];
//             mass[i,j]=mass[i,j+1];
//             mass[i,j+1]=temp;         
//             }
       
// }
// System.Console.WriteLine();
// RevesArray(new_mass);
// PrintMatrix(new_mass);


