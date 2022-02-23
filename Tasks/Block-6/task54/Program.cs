// Задача 54
// В матрице чисел найти сумму элементов главной диагонали

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
Console.WriteLine("Сумма элементов по главной диагонали :");
int summ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {

        if (i == j)
        {
            summ = summ + array[i, j];

        }
    }

}
Console.Write($" {summ}");
Console.WriteLine();

