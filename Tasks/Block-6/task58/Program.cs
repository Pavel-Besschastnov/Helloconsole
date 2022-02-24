// Задача 58
// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($" {array[i, j]}");
        }
    }
}
int temp = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    temp = array[0, j];
    array[0, j] = array[n - 1, j];
    array[n - 1, j] = temp;
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            Console.Write($" {array[i, j]}");
        }
    }
}
Console.WriteLine();
