// Задача 41: Пользователь вводит
//  с клавиатуры M чисел. Посчитайте, 
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3





int MekArray(int numuser)
{
    int count=0;
    int array =  numuser;

    for (int i = 0; i < array; i++)
    {
            if(array <0 && array ==0)
            count++;
    }

  return count;
}






System.Console.WriteLine("Введите число: ");
int numuser = int.Parse(Console.ReadLine()!);


System.Console.WriteLine(MekArray(numuser));




























