// Задача 60
// Найти произведение двух матриц

Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
int[,] massiv1 = new int[m, n];
Console.WriteLine("Матрица № 1");
for (int i = 0; i < massiv1.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv1.GetLength(1); j++)
    {
        massiv1[i, j] = new Random().Next(1, 10);
        Console.Write($"{massiv1[i, j]} ");

    }
}
Console.WriteLine();
Console.WriteLine(" Матрица №2");
int[,] massiv2 = new int[m, n];
for (int i = 0; i < massiv2.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv2.GetLength(1); j++)
    {
        massiv2[i, j] = new Random().Next(1, 10);
        Console.Write($"{massiv2[i, j]} ");

    }
}
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
int[,] matrix3 = new int[m,n];
for (int i = 0; i < massiv2.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        matrix3[i, j] = massiv1[i,j] * massiv2[i,j];
        Console.Write($"{matrix3[i, j]} ");

    }
}
Console.WriteLine();
