// Задача 3: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


void Fibonach(int[] arr)
{
    arr[1] = arr[2] =1;

   for (int i = 3; i < arr.Length; i++)
   {
    arr[i]= arr[i-1]+arr[i-2];
   }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

System.Console.Write("Ввидите число:! ");
int num = int.Parse(Console.ReadLine()!);

int[]mass = new int[num];
Fibonach(mass);
PrintArray(mass); 
