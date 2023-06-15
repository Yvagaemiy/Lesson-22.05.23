
// Задача 2: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] MekArray(int size, int from, int to)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
   {
    array[i] = new Random().Next(from, to + 1);
   } 
    return array;
}

int PrintArray(int[]array)
{
  int size = array.Length;
for (int i = 0; i < size; i++)
{
    System.Console.Write($"{array[i]} ");    
}
    return size;
}

string UserNum(int[]arr,int num )
{
    // int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < arr.Length; i++)
    {
        if(num==arr[i])
        
        return "Yes";
    }
    return"No";
}
   

System.Console.Write("Введите длину массива: ");
int numsize = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());


int[] mass = MekArray(numsize, start, stop);
System.Console.WriteLine(mass);

PrintArray(mass);
System.Console.WriteLine();

//  System.Console.WriteLine

Console.Write("Введите число: ");
System.Console.WriteLine (UserNum(mass, int.Parse(Console.ReadLine()!) ));