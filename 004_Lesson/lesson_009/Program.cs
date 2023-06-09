// Задача 1: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



int[] MekArray(int size, int from , int to)
{
     int[] array = new int[size];

     for(int i = 0; i < size; i++)
     {
         array[i] = new Random().Next(from, to+1);
     }
     return array;
      
}

int PrintArray(int[]array)
{
     int size = array.Length;

     for(int i = 0; i < size; i++)
     {
        System.Console.Write($"{array[i]} ");
     }
    return size;
}
// void PrintArray(int[]array)
// {
//      for(int i = 0; i < array.Length; i++)
//      {
//         System.Console.Write($"{array[i]} ");
//      }
// }

void ChengArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i]=array[i] * (-1);    
    }
}

System.Console.Write("введите длену массива: ");
int sizemass = Convert.ToInt32(Console.ReadLine());

System.Console.Write("введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());

int[] mass = MekArray(sizemass, start, stop);


PrintArray(mass);
System.Console.WriteLine();
ChengArray(mass);

PrintArray(mass);