// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент 
// входных данных.
// 25 мин
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


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


int[] Count(int[,]arr, int to)

{
  int[]free = new int[to + 1];
    foreach(var element in arr) //var - если даже не знаешь какие переменные в массиве
    {
     free [element]++;
    }
    return free;
}

void PrintFree(int []ar)
{
  for (int i = 0; i < ar.Length; i++)
  {
    System.Console.WriteLine($"количество {i} -> {ar[i]}");
  }
  System.Console.WriteLine();
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

int[]reez =Count(new_mass, stop);
PrintFree(reez);

