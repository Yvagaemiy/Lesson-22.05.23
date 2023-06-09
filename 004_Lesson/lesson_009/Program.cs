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
        System.Console.WriteLine($"{array[i]}");
     }
    return size;
}

System.Console.Write("введите длену массива: ");
int sizemass = Convert.ToInt32(Console.ReadLine());

System.Console.Write("введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());

int[] mass = MekArray(sizemass, start, stop);


PrintArray(mass);