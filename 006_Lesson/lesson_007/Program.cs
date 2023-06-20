//Напишите программу, которая будет создавать
//    копию заданного двумерного массива
//    с помощью поэлементного копирования.


int[,]MekArray (int row, int column, int from, int to)
{
    int[,] arra = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arra[i,j] = new Random().Next(from, to + 1);
        }
    }
    return arra;
}

void Print (int[,]arra)
{
   int row_size = arra.GetLength(0);
   int column_size = arra.GetLength(1);
for (int i = 0; i < row_size; i++)
{
    for (int j = 0; j < column_size; j++)
    {
        System.Console.Write($"{arra[i,j]} ");
    }
     Console.WriteLine();
}
     Console.WriteLine();
}
int[,]CopMass(int[,]ar)
{
   int row_size = ar.GetLength(0);
   int column_size = ar.GetLength(1);
   int[,]new_ar = new int[row_size,column_size];
   for (int i = 0; i < row_size; i++)
   {
    for (int j = 0; j < column_size; j++)
    {
        new_ar[i,j] = ar[i,j];
    }
   }
     return  new_ar;

}
System.Console.Write("Ведите строки массива:");
int numsize = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Ведите столбцы массива:");
int numhow = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Ведите начало массива:");
int  start= Convert.ToInt32(Console.ReadLine());

System.Console.Write("Ведите конец массива:");
int stop = Convert.ToInt32(Console.ReadLine());

//int[,]mass = MekArray(5,5,1,10);
int[,]mass = MekArray(numsize,numhow,start,stop);
 Print (mass);
 System.Console.WriteLine();
int[,]mass_1= CopMass(mass);
Print (mass_1);