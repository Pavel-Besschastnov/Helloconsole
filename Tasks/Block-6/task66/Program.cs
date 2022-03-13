// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

static int shown(int m, int n)
{
    {
        if (m == n) return m;
        else return m = m + shown(m + 1, n);
    }
}
Console.WriteLine(shown(m, n));
Console.WriteLine();

