// 46 задача
// Написать программу масштабирования фигуры

double[,] coor = new double[,] { { 1, 1 }, { 2, 1 }, { 2, 2 }, { 1, 2 } };
for (int i = 0; i < coor.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < coor.GetLength(1); j++)
        Console.Write($"{coor[i, j]} ");
}
Console.WriteLine();
Console.WriteLine("Введите коэфициент увеличения :");
double k = double.Parse(Console.ReadLine());
coor[1, 0] = coor[1, 0] * k;
coor[2, 0] = coor[2, 0] * k;
coor[2, 1] = coor[2, 1] * k;
coor[3, 1] = coor[3, 1] * k;
for (int i = 0; i < coor.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < coor.GetLength(1); j++)
    {
        Console.Write($" {coor[i, j]}");
    }
}
Console.WriteLine();