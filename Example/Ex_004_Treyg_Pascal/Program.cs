
int row = 128;

int[,] triangel=new int[row, row];

const int cellWidth= 1;  //количество ячеек для вывода элемента

void FillTriangel()
{
   for (int i = 0; i < row; i++)
   {
        triangel[i,0] = 1;  //заполняет его 1
        triangel[i,i] = 1;   //заполняет его 1
   }
        for (int i = 2; i < row; i++)// со второй строки заполняем
        {
             for (int j = 1; j <= i; j++)
             {
                triangel[i,j] = triangel[i-1, j-1] + triangel[i-1, j];//сумма текущего элеиента равна сумме элемента над ним treangel[i-1, j-1] 
                //плюс элемент который выше и левее.
             }
        }
    
}

void PrintTriangl()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
           {   
            if(triangel[i,j] != 0 ) 
            System.Console.Write($"{triangel[i,j],cellWidth }");
           }
        System.Console.WriteLine();
    }
}
 void Magic()
 {
    int col = row + cellWidth;
     for (int i = 0; i < row; i++)
     {
        for (int j = 0; j <=i ; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            //if (triangel[i,j] != 0) System.Console.Write($"{triangel[i,j],cellWidth}");
            if (triangel[i,j] %2 != 0) System.Console.Write("*");
            col = col + cellWidth * 2;
        }
       col = cellWidth * row - cellWidth * (i + 1);

       System.Console.WriteLine();
     }

 }

FillTriangel();
//PrintTriangl();
Magic();
