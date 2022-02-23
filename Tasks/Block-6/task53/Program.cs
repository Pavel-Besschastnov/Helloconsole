// Задача 53
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет


Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 100);
        Console.Write($" {array[i, j]}");
    }
}
Console.WriteLine();
Console.WriteLine("Введите нужное число :");
int num = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == num)
        {
            count++;
            Console.WriteLine($"число найдено! Его индекс m= {i} n={j}");
        }

    }
}
if (count == 0) Console.WriteLine("Такого числа в массиве нет");