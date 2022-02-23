// Задача 52
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите количество столбцов :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
int[,] massiv = new int[m, n];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Создан и заполнен массив.");
for (int i = 0; i < massiv.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        Console.Write($" {massiv[i, j]}");
    }
}
for (int i = 0; i < massiv.GetLength(0); i++)
{

    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0) massiv[i, j] = massiv[i, j] * massiv[i, j];

    }

}
Console.WriteLine();
Console.WriteLine("элементы с чеьными индексами возведены в квадрат");
for (int i = 0; i < massiv.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        Console.Write($" {massiv[i, j]}");
    }
}