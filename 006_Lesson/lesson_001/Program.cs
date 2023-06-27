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

void PrintArray (int[]arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    System.Console.Write($"{arr[i]}, ");
  }
  System.Console.WriteLine();
}


System.Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);
int[]array = new int[size];

FillArray(array);
PrintArray(array);




//        void  BubbleSort(array);
//  {
//             Console.WriteLine("После сортировки:");
//             for (int i = 0; i < array.Length; i++)
//             {
//                 Console.WriteLine(array[i]);
//             }
//  }          
//      BubbleSort(array);    
 
void RevesArray(int[]mass)
{
    for (int i=0; i<mass.Length-1;i++)

       for (int j=0;j<mass.Length-1;j++)

            if (mass[j]>mass[j+1])

            {

            int temp=mass[j];

            mass[j]=mass[j+1];

            mass[j+1]=temp;
            }

}
RevesArray(array);
PrintArray(array);


// void Reves(int[]mass) //Осуществляется поиск максимального элемента во всем массиве, затем он меняется с последним элементом.
// {
//   int leng = mass.Length;
//             for (int i=0;i<leng-1;i++)
// {
            

//             int i_max=0;

//             for (int j=0;j<leng;j++) 
            
//             if (mass[j]>mass[i_max]) 
            
//             i_max=j;

//             int temp=mass[i_max];

//             mass[i_max]=mass[leng-1];

//             mass[leng-1]=temp;

//             leng--;
// }
            
// }

// Reves(array);
// PrintArray(array);



// void bubble_sort(long list[], long n)
// {
//   long c, d, t;
 
//   for (c = 0 ; c < ( n - 1 ); c++)
//   {
//     for (d = 0 ; d < n - c - 1; d++)
//     {
//       if (list[d] > list[d+1])
//       {
//         /* Swapping */
 
//         t         = list[d];
//         list[d]   = list[d+1];
//         list[d+1] = t;
//       }
//     }
//   }





