
// Напишите програму вычесления функции Аккермана с помощью рекурсии.
// Даны два не отрецательных числа m и n.
// m=2,n=3 -> A(m,n) = 9
// m=3,n=2 -> A(m,n) = 29
//скачена с инета т.к. ни чегои не понял.
int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0))
  
    return Akkerman(n - 1, 1);
    return Akkerman(n - 1,Akkerman(n, m - 1));
}
System.Console.Write("введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"A(m,n) = {Akkerman(m, n)}");
