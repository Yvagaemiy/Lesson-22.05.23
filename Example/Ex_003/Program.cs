
 int [] array = {12,43,56,7,32,90,78,14,54,55,87,32,97,456};

 int n = array.Length;

 int find = 6;//ищет ползователь

int index = 0 ;//старт индекса

while (index < n)//делаем пока индекс меньше n
 {
     if (array[index] == find)//если массив с индексом раве find
       {
       Console.WriteLine(index);//консоль покажи индекс
       break;
       }
index++;//а до этого прибовляем +1индекс

 }



 System.Console.WriteLine(array);
//int[] array = new int[5];

// void FilArray (int [] какойтомассив)
// { 
//  int count = какойтомассив.Length;
//  int index = 0;
//     while(index < count)
//     {
//         какойтомассив[index]= new Random().Next();
//         index++;
//     }    
// }

// void PrintArray(int[] недомассив)
// {
//     int чтото = недомассив.Length;
//     int позиция = 0;
//     while (позиция < чтото)
//     {
//         Console.Write($"{позиция} ");
//         позиция++;
//     }
// }



// FilArray(array);
// PrintArray(array);