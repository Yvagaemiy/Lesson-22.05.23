
// Задача необязательная 1: на входе
//  целое или вещественное число, надо удалить 
//  вторую цифру слева этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

// Console.WriteLine("Введите число:");
// double num = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(1, 1000);
    Console.WriteLine(num); 

{
 while (num >= 1000-1)
   {
    num = num /10;
   double n =num;
   }
    if (num < 99) 
   {
    Console.WriteLine("число не трех значное");  
   }
//    else 
//    {
//      Console.Write($"третья цифра = {num/10}");
//    }

}
double x1 = num %10;
double x2 = num /100;

Console.WriteLine($" -> {x2*10+x1}");


    

 
