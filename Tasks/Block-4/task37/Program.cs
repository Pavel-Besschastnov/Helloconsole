// Задача 37
// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

using static System.Console;
int[] array=new int[123];
WriteLine(" Дан массив чисел");
for(int i=0 ;i<123;i++)
{
array[i]=new Random().Next(-100,200);
Console.Write($" {array[i]}");
}
int count =0;
Console.WriteLine();
foreach(int a in array)
{
if(a>10 && a<99)count++;
}
Console.WriteLine($"количество чисел лежащих в отрезке[10,99]={count}");