// Задача 35
// Определить, присутствует ли в заданном массиве, некоторое число

using static System.Console;
int[] numb = new int[20];
for (int i = 0; i < numb.Length; i++)
{
    numb[i] = new Random().Next(0, 20);
    Write($" {numb[i]}");
}

WriteLine();
WriteLine(" Введите число :");
int num = int.Parse(ReadLine());
int count = 0;
for (int j = 0; j < 20; j++)
{
    if (numb[j] == num) count++; 

}
if(count>0)
{
    WriteLine($"такое число есть в массиве");
}
else
{
    WriteLine( " такого числа нет в массиве");
}
