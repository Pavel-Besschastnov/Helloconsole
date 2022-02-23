// Задача 50
// В двумерном массиве n×k заменить четные элементы на противоположные

using static System.Console;
Console.Clear();
int m = int.Parse(ReadLine());
int n = int.Parse(ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int d = 0; d < n; d++)
    {
        array[i, d] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i, j] % 2 == 0) array[i,j]=(array[i, j] * (-1));
        Write($" ( {array[i, j]} )");
    }
    WriteLine();
}