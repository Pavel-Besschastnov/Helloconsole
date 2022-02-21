  // Задача 48
  //  Показать двумерный массив размером m×n заполненный целыми числами
  using static System.Console;
  Console.Clear();
int m= int.Parse(ReadLine());
int n= int.Parse(ReadLine());
int[,] array = new int[m,n];
 for(int i=0;i<m;i++)
 {
     for(int d=0;d<n;d++)
     {
         array[i,d]= new Random().Next(10,100);
     }
 }
 for (int i=0;i<m;i++)
 {
     for(int j =0;j<n;j++)
     {
         Write($" ( {array[i,j]} )");
     }
     WriteLine();
 }