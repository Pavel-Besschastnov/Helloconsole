// Задача 31
// Задать массив из 8 элементов и вывести их на экран

using static System.Console;

int[] numbers = new int[8];
for (int d = 0; d < 8; d++)
{
    numbers[d] = new Random().Next(1, 99);
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}