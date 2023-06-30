// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользовател


int[,]Matrix (int row, int coulmn, int from, int to)
{
    int[,]new_matrix = new int [row, coulmn];
    for (int i = 0; i < row; i++)
    {
       for (int j = 0; j <coulmn; j++)
       new_matrix[i,j] = new Random().Next(from,to+1);
    }
    return new_matrix;
}

void Print (int[,]array)
{
    int row_s = array.GetLength(0);
    int column_s = array.GetLength(1);

    for (int i = 0; i < row_s; i++)
    {
        for (int j = 0; j < column_s; j++)
        
            System.Console.Write($"{array[i,j],3}");
            System.Console.WriteLine();        
    }
}
void ChengRowCluomn(int[,]arr)
{

    int row_ss = arr.GetLength(0);
    int column_ss = arr.GetLength(1);

    for (int i = 0; i < row_ss; i++)
    {
        for (int j = 0; j < i; j++)//можно еще прировнять j к i  for (int j = i; j < column_ss; j++)

             if( row_ss==column_ss)
               {
                int temp = arr[i,j];
                arr[i,j] = arr[j,i];
                arr[j,i] = temp;
               }
            else
            {
             System.Console.WriteLine(" это невозможно");
            }
    }
}

System.Console.Write("Введите строки массива:");
int row_size= Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбцы массива:");
int coulmn_size= Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива:");
int start= Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива:");
int stop= Convert.ToInt32(Console.ReadLine());

int[,]new_mass = Matrix ( row_size,  coulmn_size, start, stop);


Print (new_mass);
System.Console.WriteLine();
 ChengRowCluomn(new_mass);
 Print (new_mass);




