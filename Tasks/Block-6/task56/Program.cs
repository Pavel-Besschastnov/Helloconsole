// Задача 56
// Написать программу, которая обменивает элементы первой строки и последней строки

Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    if (i == 0 || i == array.GetLength(0) - 1)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($" {array[i, j]}");
        }
    }
}
