// Решение в группах задач:
// Задача 2: Задайте двумерный массив. Найдите элементы, у которых 
// обе позиции чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2      
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


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
void NewArray(int [,]array)
{
    if (array.GetLength(0)%2==0)
    for (int i = 0; i < array.GetLength(0); i++)
    
      array[i]= array[i]*array[i];
    
     if (array.GetLength(1)%2==0)
    for (int j = 0; j < array.GetLength(1); j++)
    
      array[j]= array[j]*array[j];
    
    // return array[i];
    // return array[j];
}
System.Console.Write("Введите количество строк: ");
int row_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int column_s = Convert.ToInt32(Console.ReadLine());


int[,]new_matrix =  new int[row_s, column_s];
FullMatrix(new_matrix);
PrintArray(new_matrix);

int[,]new_matrix_1 = NewArray();
NewArray(new_matrix);
PrintArray(new_matrix_1);