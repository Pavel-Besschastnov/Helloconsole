// Задача 34
// Написать программу замену элементов массива на противоположные
using static System.Console;
int[] massiv = new int[11];
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(0, 10);
    Write($" {massiv[i]}");
}
WriteLine();
for (int j = 0; j < massiv.Length-1; j++)
{
    if (j != massiv.Length - (j+1))
    {
        int temp = massiv[massiv.Length - (j+1)];
        massiv[massiv.Length - (j+1)] = massiv[j];
        massiv[j] = temp;
    }


}
WriteLine(" Массив наоборот:");
foreach (int a in massiv)
{
    Write($" {a}");
}
WriteLine();