// Задача 36
// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
using static System.Console;
int[] mass = new int[10];
WriteLine(" задан массив с трехзначными числами");
for (int i = 0; i < 10; i++)
{
    mass[i] = new Random().Next(100, 999);
    Write($"{mass[i]} ");
}
int chet = 0;
int nechet = 0;
for (int j = 0; j < 10; j++)
{
    if (mass[j] % 2 == 0) chet++;
    else nechet++;
}
WriteLine();
WriteLine($"количество четных = {chet}");
WriteLine($"количество нечетных ={nechet}");