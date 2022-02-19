 // Задача 39
 // Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

using static System.Console;
int[] numb=new int[10];
for(int i=0;i<10;i++)
{
numb[i]=new Random().Next(1,10);
Console.Write($" {numb[i]}");
}
Console.WriteLine();
Console.WriteLine();
int summ=0;
int a= 0;
int b= numb.Length-1;
while( a<b-1)
{
summ= numb[a]*numb[b];
Console.Write($" {summ}");
a++;
}