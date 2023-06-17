// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом 
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[]array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i]= new Random().Next(-9, 10);
  }
}

void PrintArray (int[]array)
{
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.WriteLine();
}

void RevesArray(int[]array)
{
 int temp=0;
 for (int i = 0; i < array.Length / 2; i++)
 {
    temp = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = array[i];
    array[i] = temp;
 }


}

System.Console.WriteLine("Введите число: ");
int size = int.Parse(Console.ReadLine()!);

int[]array = new int[size];

FillArray(array);
PrintArray(array);
RevesArray(array);
PrintArray(array);