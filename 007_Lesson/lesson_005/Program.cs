// : Задайте двумерный массив. Введите элемент, и найдите 
// первое его вхождение, выведите позиции по горизонтали и 
// вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.


int[,] MatrixArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)

            array[i, j] = new Random().Next(from, to + 1);
    }
    return array;
}

void PrintArray(int[,] arr)

{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            System.Console.Write($"{arr[i, j],3}");
        System.Console.WriteLine();
    }

}


System.Console.Write("Введите количество строк: ");
int row_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int column_s = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());


int[,] new_matrix = MatrixArray(row_s, column_s, start, stop);

PrintArray(new_matrix);





System.Console.Write("Введите число: ");
int usenumber = Convert.ToInt32(Console.ReadLine());

string ZeroArray(int[,] arra, int n)
{ 
    for (int i = 0; i < arra.GetLength(0); i++) 
    {   
        for (int j = 0; j < arra.GetLength(1); j++)  
        {
             if (arra[i, j] == n)  
             return $"Искомое число {n} координаты :[{i + 1},{j + 1}]"; 
        }    
    }                
    return $"элемента {n} нет"; 
}
System.Console.Write(ZeroArray(new_matrix, usenumber));
