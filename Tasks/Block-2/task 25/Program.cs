// Задача 25
// Найти сумму чисел от 1 до A

using static System.Console;

int A= new Random().Next(1,20);
WriteLine($"N = {A}");
int result =0;
for (int i = 0; i < A+1; i++)
{
    result=result + i;
}
WriteLine( $"Сумма чисел ={result}");
