// Задача 24
//Найти кубы чисел от 1 до N

using static System.Console;


int N= new Random().Next(1,20);
WriteLine($"N = {N}");

for (int i = 0; i < N+1; i++)
{
    int temp = i * i;
    WriteLine($"N ^ 2 = {temp}");

}

