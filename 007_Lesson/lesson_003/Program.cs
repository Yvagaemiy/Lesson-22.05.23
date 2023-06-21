// : Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится по формуле: Aₙₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



int[,] FullMatrix(int[,]array )
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    
        array[i,j] = i+j;
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

