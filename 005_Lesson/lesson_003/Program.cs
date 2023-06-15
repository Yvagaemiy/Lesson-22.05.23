// Задача 1: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



int[]Mekarray(int size, int from, int to)
{
    int[]array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from,to +1);
    }
    return array;
}
       

int PrintArray(int[]array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
       System.Console.Write($"{array[i]}  "); 
    }
    return size;
}

void Sum (int[]array)
{
  for (int i = 0; i <array.Length; i++)
  {
    array[i] = array[i]*(-1);
  }
}


int Sum2 (int[]array)
{
  int resulte = 0;
  for (int i = 0; i <array.Length; i++)
  {
    resulte = array[i]*(-1);
  }
  return resulte;
}



System.Console.Write("Введите длину массива: ");
int numsize = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите начало массива: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите конец массива: ");
int stop = Convert.ToInt32(Console.ReadLine());

int[]massiv = Mekarray(numsize,start, stop);

System.Console.WriteLine(massiv);

PrintArray(massiv);
System.Console.WriteLine();

Sum(massiv);
PrintArray(massiv);

System.Console.WriteLine();
Sum2(massiv);
PrintArray(massiv);