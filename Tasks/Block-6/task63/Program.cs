// Задача 63
// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

Console.WriteLine("Введите количество уровней:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов :");
int n = int.Parse(Console.ReadLine());
int[,,] massiv = new int[b, m, n];
for (int i = 0; i < massiv.GetLength(0); i++)
{

    for (int j = 0; j < massiv.GetLength(1); j++)
    {

        for (int d = 0; d < massiv.GetLength(2); d++)
        {
            massiv[i, j, d] = new Random().Next(10, 100);
            while (foundarray(massiv, massiv[i, j, d]) > 1)
            {
                massiv[i, j, d] = new Random().Next(10, 100);
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
        Console.WriteLine();
        for (int d = 0; d < massiv.GetLength(2); d++)
        {

            Console.Write($" {massiv[i, j, d]}");
        }
    }

}
Console.WriteLine();
static int foundarray(int[,,] array, int chis)
{

    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int d = 0; d < array.GetLength(2); d++)
            {
                if (array[i, j, d] == chis) count++;
            }
        }
    }
    return count;
}