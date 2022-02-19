// Задача 33
// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
using static System.Console;

int[] array = new int[12];
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(0, 9);
    Console.Write($" { array[i] }");
}
Console.WriteLine();
int chet = 0;
int nechet = 0;
for (int j = 0; j < 12; j++)
{
    if (array[j] % 2 == 0) chet++;
    else nechet++;
}
Console.WriteLine($" Количество четных символов в массиве ={chet}");
Console.WriteLine($" Количество нечетных символов в массиве = {nechet}");
