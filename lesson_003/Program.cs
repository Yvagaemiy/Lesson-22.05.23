/*
Console.WriteLine("Введитечисло : ");

int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
    Console.WriteLine("ПН");
    break;
    case 2:
    Console.WriteLine("ВТ");
    break;
    case 3:
    Console.WriteLine("СР");
    break;
    case 4:
    Console.WriteLine("ЧТ");
    break;
    case 5:
    Console.WriteLine("ПТ");
    break;
    case 6:
    Console.WriteLine("СБ");
    break;
    case 7:
    Console.WriteLine("ВС");
    break;
    default:
     Console.WriteLine("такого дня недели нет");
    break;
}
*/
Console.WriteLine("Введитечисло : ");

int num = Convert.ToInt32(Console.ReadLine());

string[] arry = {"пн","вт","ср","чт","пт","сб","вс"};

Console.WriteLine(arry[num-1]);
