// 40 задача
// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
using static System.Console;
double[] massiv = new double[] { 10.23, 2.34, 1.23, 3.6546, 3.343, 3.45, 8.23, 3.443, 6.45, 31.12 };
WriteLine(" Задан массив");
for (int i = 0; i < massiv.Length; i++)
{
    Write($"   {massiv[i]}");
}
double max1 = 0;
double min1 = massiv[massiv.Length-1];
WriteLine();
for (int j = 0; j < massiv.Length; j++)
{
  if( max1<massiv[j]) max1=massiv[j];
  if(min1>massiv[j]) min1=massiv[j]; 
}
WriteLine($" максимальное число: {max1} ");
WriteLine($" Минимальное число: {min1}");
double dif = max1 - min1;
WriteLine($" Разница между максимальным и минимальным значением : {dif}");







