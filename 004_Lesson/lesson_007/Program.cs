// Задача 3: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.

   //ЗАДАЧА № 1

// int GenershonNumber()
// {
// int num = new Random().Next(0, 2);//рондоим от 0 до 1
// return num;
// }
//Console.WriteLine(GenershonNumber());

// void PrintArray(int[] array)  // не обязательный метод
// {
//     int massiv = array.Length;
//     for(int i =0;i < massiv ;i++)
//   {
//    System.Console.Write($"{array[i]}");
//   }

// }

// int[] MekArray()
// {   
//     int[] arr = new int[12];
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = GenershonNumber();
//         Console.Write($"{arr[i]} ");
//     } 
//     return arr; 
//     // Console.ReadLine();  
// }
// Console.WriteLine(MekArray());


            //ЗАДАЧА №2


// int[] MekArray()
// {
//     int[] array = new int[8];
    
//     for(int i =0;i<array.Length;i++)
//     {
//       array[i]=  new Random().Next(0,2);                       
//     Console.Write($"{array[i]} "); 
//     }
//     return array;  
// }
 
//  int[] resulte = MekArray();

//  System.Console.WriteLine(resulte);


         //ЗАДАЧА № 3

int PrintArray(int[]array)
{
    int size = array.Length;
    for (int i = 0; i<size; i++)
  {
   System.Console.Write($"{array[i]} ");
  }
return size;
}


int[]MekArray(int size,int from,int to)
{
  int[]array = new int[size];
  for(int i = 0; i<size; i++)
  {
     array[i]=new Random().Next(from, to +1);
  }
return array;

}
System.Console.WriteLine("Введите длину: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите начало диапозона: ");
int start = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите конец диапозона: ");
int stop = Convert.ToInt32(Console.ReadLine());

int[]mass = MekArray( num,  start, stop);

PrintArray(mass);