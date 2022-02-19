// Задача 34
// Написать программу замену элементов массива на противоположные

int[] massiv = new int[10];
for (int i = 0; i < 10; i++)
{
    massiv[i] = new Random().Next(-10, 10);
    Console.Write($" {massiv[i]}");
}
Console.WriteLine();
for (int j = 0; j < 10; j++)
{

    massiv[j] = massiv[j] * -1;
}
foreach (int d in massiv)
{
    Console.Write("{0} ", d);
}