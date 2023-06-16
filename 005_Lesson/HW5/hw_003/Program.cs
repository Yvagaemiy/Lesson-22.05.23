// Задача 38: Задайте массив вещественных 
// случайных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.


double[]MekArray(int size, int from, int to)
{
  double[]array = new double[size];
  Random new_num = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new_num.NextDouble() * (to - from) + from, 2 );// 2- это два нуля после запятой
    }
   return array;
}
int PrintArray(double[]array)
{
   int size = array.Length;
   for (int i = 0; i < size; i++)
   {
     System.Console.Write($"[{array[i]}] ");
   }
    return size;
}
void DiFFMaxMin(double[]arr)
{
double max = arr[0];
double min =arr[0] ;

for (int i = 0; i < arr.Length; i++)

    if (arr[i]> max)
    max = arr[i];
    else if (arr[i]< min)
    min = arr[i];
    System.Console.WriteLine();
    System.Console.WriteLine($"минимальный элемент массива     = {min}");

    System.Console.WriteLine($"максимальный элемент массива    = {max}");

    double resylte = Math.Round (max - min, 2);// 2- это два нуля после запятой
   
    System.Console.WriteLine($"разница между маx и мin массива = {resylte}");
}

int numsize = 5;
int start = 0 ;
int stop = 50;

double[]mass = MekArray(numsize, start, stop);
PrintArray(mass);
DiFFMaxMin(mass);

