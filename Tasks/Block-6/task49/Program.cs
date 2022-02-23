// Задача 49 
// Показать двумерный массив размером m×n, заполненный вещественными числами.

Console.WriteLine("Введите количество столбцов :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{

    for (int j = 0; j < n; j++)
    {
        array[i, j] = (new Random().NextDouble() * 5);
        Console.Write($" {array[i, j]}");
    }
}
Console.WriteLine();
