// Задача 2: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
string NewNumber (int num)
{
    string numnew = "";
    while(num > 0)
  {
    numnew = Convert.ToString(num % 2) + numnew;
    num= num/2;
  
  }
   return numnew;

}

System.Console.Write("Введите десятичное число: ");


int num =  int.Parse(Console.ReadLine()!);

System.Console.Write($"Двоичное число =          {NewNumber (num)}");