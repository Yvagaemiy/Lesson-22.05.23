// Задача 52. Задайте двумерный
//  массив из целых чисел. Найдите 
//  среднее арифметическое элементов
//   в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,]Matrix(double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j]= new Random().Next(1,10);
    }
     return array;
}

void PrintMatrix(double[,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
         System.Console.Write($"{arr[i,j],3}");
         System.Console.WriteLine();
    }
}


void ArithmeticMean(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double sum;

    for (int i = 0; i <column ;i++)
    {
        sum = 0;
        for (int j = 0; j <row; j++)
        sum = sum + arr[j, i];
        Console.Write($"{Math.Round(sum / row , 2)}; ");
        //System.Console.WriteLine();
    }
}

System.Console.Write("Введите строки массива:  ");
int row = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите столбци массива: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,]new_matrix = new double[row,column];
Matrix(new_matrix);
PrintMatrix(new_matrix);

 ArithmeticMean(new_matrix);
//System.Console.WriteLine($"Среднее арифметическое каждого столбца:{SredColumn(new_matrix)}");
// double[,]new_2_matrix = Matrix(new_matrix);
// SredColumn(new_2_matrix);

// PrintMatrix(new_2_matrix);


