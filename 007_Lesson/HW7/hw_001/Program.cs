// Задача 47. Задайте двумерный массив
//  размером m×n, заполненный случайными 
//  вещественными числами.
// m = 3, n = 4.
// 0,5     7   -2    -0,2
//   1  -3,3    8    -9,9
//   8   7,8 -7,1       9


int[,]MekMatrix(int[,]array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
      for (int j = 0; j < array.GetLength(1); j++)
       array[i,j] = new Random().Next(-20,20); 
      }
    return array;   
}
void PrintMatrix(int[,]arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
     {
          for (int j = 0; j < arr.GetLength(1); j++)
          System.Console.Write($"{arr[i,j],3}");
          System.Console.WriteLine();
     }
}
System.Console.Write("Введите количество строк: ");
int row_size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int column_size = Convert.ToInt32(Console.ReadLine());


int[,]mass = new int[row_size,column_size];
MekMatrix(mass);
PrintMatrix(mass);