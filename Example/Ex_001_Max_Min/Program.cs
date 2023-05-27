// int Max(int arg1, int arg2,int arg3)
// {
//      int resulte = arg1;
//      if(arg2 > resulte) resulte = arg2;
//      if(arg3 > resulte) resulte = arg3;
//     return resulte;

// }

// int a1 =345;
// int b1 =34;
// int c1 = 21;

// int a2 =45;
// int b2 =3466;
// int c2 = 212;

// int a3 =4544;
// int b3 =645756867;
// int c3 = 22;

// int max1= Max(a1 ,b1, c1);

// int max2= Max(a2 ,b2, c2);

// int max3= Max(a3 ,b3, c3);

// int max = Max(max1, max2, max3);
// Console.WriteLine(max);

int Min(int arg1,int arg2,int arg3)
{
    int resulte = arg1;
    if (arg2< resulte) resulte = arg2;
    if (arg3 < resulte) resulte = arg3;
    return resulte;
}
int a1= new Random().Next(1, 10);
Console.WriteLine($"число1: {a1}");
int b1= new Random().Next(1, 10);
Console.WriteLine($"число2: {b1}");
int c1= new Random().Next(1, 10);
Console.WriteLine($"число3: {c1}");
int min= Min(a1,b1,c1);

 Console.WriteLine($"минимальное число: {min}");