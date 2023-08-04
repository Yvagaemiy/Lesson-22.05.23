

Console.Write("Введите  число : ");

int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число : ");

int finish = Convert.ToInt32(Console.ReadLine());


for (int i = start ;i <= finish; i++)

{
     if( i % 2 ==0)
    Console.Write(i + ",");
}