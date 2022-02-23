// 51 Задача
// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк :");
int n = int.Parse(Console.ReadLine());
int[,] massiv = new int[m, n];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = i + j;
    }
}
for (int i = 0; i < massiv.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        Console.Write($" {massiv[i, j]}");
    }
}
Console.WriteLine();