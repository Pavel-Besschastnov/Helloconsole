// Задача 38
// Найти сумму чисел одномерного массива стоящих на нечетной позиции
using static System.Console;
int[] massiv = new int[123];
for (int i = 0; i < 123; i++)
{
    massiv[i] = new Random().Next(0, 300);
    Console.Write($" {massiv[i]}");
}
Console.WriteLine();
int summ = 0;
for (int j = 0; j < massiv.Length; j++)
{
    if (j % 2 != 0) summ = summ + massiv[j];

}
Console.WriteLine($"Сумма элементов стоящих на нечетной позиции = {summ}");