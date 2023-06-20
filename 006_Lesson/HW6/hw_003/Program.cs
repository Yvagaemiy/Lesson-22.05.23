
// Задача НЕГАФИБОНАЧЧИ необязательная. Задайте 
// число. Составьте массив чисел НегаФибоначчи, в 
// том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


void Fibonach(int []arr)
{
    arr[arr.Length/2] = 0;
    arr[arr.Length/2+1] = 1;
    arr[arr.Length/2-1] = 1;
    // arr[0]=0;
    // arr[1]=1;
    // arr[2]=1;

    for (int i =arr.Length/2+2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
 
    for (int i = 0; i < arr.Length /2-1 ; i++)
   {
    arr[i] = arr[arr.Length-1-i];
    if(i % 2 == 0) 
    arr[i]= arr[i] * -1;
//     // temp = array[array.Length - 1 - i]*(-1);
//     // array[array.Length - 1 - i] = array[i];
//     // array[i] = temp;
   
//     //array[i] = temp*(-1);

   }


}

void PrintArray(int[]array)
{
    for (int i = 0;i < array.Length; i++)
    {
        // System.Console.Write($"{array[i]*(-1)}, {array[i]}");
        System.Console.Write($"{array[i]} ");
    }
}

// void Rev(double[] ar)
// {
// for (int i = 0; i < ar.Length; i++)

//     while (ar[i] != 0);

//    ar[ar.Length] --;

// }
System.Console.Write("Введите число");
int num = int.Parse(Console.ReadLine()!);

int[]mass = new int [ num*2-1];

Fibonach(mass);
PrintArray(mass);

// RevesArray(mass);
// PrintArray(mass);




