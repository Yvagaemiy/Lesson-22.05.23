// Задача 50. Напишите программу, которая на 
// вход принимает значение элемента в двумерном
//  массиве, и возвращает позицию этого элемента 
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,]MekMatrix(int [,]array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
       for (int j = 0; j < array.GetLength(1); j++)
         array[i,j] = new Random().Next(-20,20); 
   }
   return array;
}

void PrintMatrix(int [,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
        System.Console.Write($"{arr[i,j],3} "); 
        System.Console.WriteLine();
   } 
}

System.Console.Write("Введите строки массива:  ");
int row = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбци массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,]new_mass = new int [row, column];
MekMatrix(new_mass);
PrintMatrix(new_mass);

System.Console.Write("Введите число: ");
int usernum = Convert.ToInt32(Console.ReadLine());

string Number(int[,]arr, int num)
{
  for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
         if (arr[i,j]==num)
         return $"Искомое число: {num} позиция элемента: [{j},{i}]";//arr[{f}, {s}] = {arr[f - 1, s - 1]}
       }
   }
   return $"Искомое число: {num} такого числа в массиве нет ";
}

System.Console.WriteLine(Number(new_mass, usernum));