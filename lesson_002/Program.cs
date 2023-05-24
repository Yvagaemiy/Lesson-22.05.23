
/*

Console.WriteLine("введите число 1 : ");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите число 2 : ");
//int numB = Convert.ToInt32(Console.ReadLine());
int numB = int.Parse(Console.ReadLine()!);
if( numB == numA*numA)
{
   Console.WriteLine("первое число квадрат второго");


}
else
{
    Console.WriteLine("первое число НЕ квадрат второго");
}
*/

/*int ПН = 1 ;
int ВТ = 2 ;
int СР = 3 ;
int ЧТ = 4 ;
int ПТ = 5 ;
int СБ = 6 ;
int ВС = 7 ; 
*/
Console.WriteLine("введите число  : ");
int num = int.Parse(Console.ReadLine()!);
if (num ==1)
{
Console.WriteLine("ПН ");
}
else if (num ==2)
{
Console.WriteLine("ВТ ");
}
else if (num ==3)
{
Console.WriteLine("СР ");
}
else if (num ==4)
{
Console.WriteLine("ЧТ ");
}
else if (num ==5)
{
Console.WriteLine("ПТ ");
}
else if (num ==6)
{
Console.WriteLine("СБ ");
}
else if (num ==7)
{
Console.WriteLine("ВС ");
}
else
{
    Console.WriteLine("Токого дня недели нет");
}