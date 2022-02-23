// Задача 55
// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($" {array[i, j]}");
    }
}
Console.WriteLine();
int summ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{



    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ = summ + array[j, i];

    }
    if (summ > 0) Console.WriteLine($"Среднее арифметическое {(i + 1)} столбца : {summ/n}");
     summ = 0;
}