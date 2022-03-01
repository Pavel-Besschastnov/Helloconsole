// Задача 59
// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
if (m == n)
{
    Console.WriteLine("Выполнение невозможно");
    return;
}
int[,] massiv = new int[m, n];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(1, 10);
        Console.Write($"{massiv[i, j]} ");

    }

}
Console.WriteLine();
int summ = 0;
int minin = summ;
int s = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
{

    if (summ != 0 && minin > summ)
    {
        minin = summ;
        s = i;

    }
    summ = 0;
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        summ = summ + massiv[i, j];
        if (i == 0) minin = summ;

    }
}
Console.WriteLine($" Наименьшая сумма элементов в строке №{s} и равна : {minin}");