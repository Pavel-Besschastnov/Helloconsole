// Задача 57
// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
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

for (int i = 0; i < massiv.GetLength(0); i++)
{



    for (int d = 0; d < massiv.GetLength(1); d++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (j != massiv.GetLength(1) - 1)

            {
                if (massiv[i, j] > massiv[i, j + 1])
                {
                    int minstrok = massiv[i, j + 1];
                    massiv[i, j + 1] = massiv[i, j];
                    massiv[i, j] = minstrok;

                }
            }
        }
    }
}
Console.WriteLine();

for (int i = 0; i < massiv.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        Console.Write($"{massiv[i, j]} ");
    }
}







