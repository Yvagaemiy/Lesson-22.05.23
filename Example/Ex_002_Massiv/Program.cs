int Max(int arg1, int arg2,int arg3)
{
     int resulte = arg1;
     if(arg2 > resulte) resulte = arg2;
     if(arg3 > resulte) resulte = arg3;
    return resulte;

}
int[] array ={2,4,7,95,5,78,21,36,19};
// array[3]= 2;

// Console.WriteLine(array[7]);


int max = Max(Max(array[0],array[1],array[2]),
              Max(array[3],array[4],array[5]),
              Max(array[6],array[7],array[8]));

Console.WriteLine(max);
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